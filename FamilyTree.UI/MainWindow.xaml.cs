using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FamilyTree.UI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Viewbox child;
        private Point origin;
        private Point start;
        public MainWindow()
        {
            InitializeComponent();
            child = viewbox;
            TransformGroup group = new TransformGroup();
            ScaleTransform st = new ScaleTransform();
            group.Children.Add(st);
            TranslateTransform tt = new TranslateTransform();
            group.Children.Add(tt);
            child.RenderTransform = group;
            child.RenderTransformOrigin = new Point(0.0, 0.0);
            this.MouseWheel += child_MouseWheel;
            this.MouseLeftButtonDown += child_MouseLeftButtonDown;
            this.MouseLeftButtonUp += child_MouseLeftButtonUp;
            this.MouseMove += child_MouseMove;
            this.PreviewMouseRightButtonDown += new MouseButtonEventHandler(
              child_PreviewMouseRightButtonDown);
        }

        private ScaleTransform GetScaleTransform(UIElement element)
        {
            return (ScaleTransform)((TransformGroup)element.RenderTransform)
              .Children.First(tr => tr is ScaleTransform);
        }
        private TranslateTransform GetTranslateTransform(UIElement element)
        {
            return (TranslateTransform)((TransformGroup)element.RenderTransform)
              .Children.First(tr => tr is TranslateTransform);
        }

        public void Reset()
        {
            if (child != null)
            {
                // reset zoom
                var st = GetScaleTransform(child);
                st.ScaleX = 1.0;
                st.ScaleY = 1.0;

                // reset pan
                var tt = GetTranslateTransform(child);
                tt.X = 0.0;
                tt.Y = 0.0;
            }
        }

        private void child_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (child != null)
            {
                var st = GetScaleTransform(child);
                var tt = GetTranslateTransform(child);

                double zoom = e.Delta > 0 ? .2 : -.2;
                if (!(e.Delta > 0) && (st.ScaleX < .3 || st.ScaleY < .3))
                    return;

                Point relative = e.GetPosition(child);
                double absoluteX;
                double absoluteY;

                absoluteX = relative.X * st.ScaleX + tt.X;
                absoluteY = relative.Y * st.ScaleY + tt.Y;

                st.ScaleX += zoom;
                st.ScaleY += zoom;

                tt.X = absoluteX - relative.X * st.ScaleX;
                tt.Y = absoluteY - relative.Y * st.ScaleY;
            }
        }

        private void child_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (child != null)
            {
                var tt = GetTranslateTransform(child);
                start = e.GetPosition(this);
                origin = new Point(tt.X, tt.Y);
                this.Cursor = Cursors.Hand;
                child.CaptureMouse();
            }
        }

        private void child_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (child != null)
            {
                child.ReleaseMouseCapture();
                this.Cursor = Cursors.Arrow;
            }
        }

        void child_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Reset();
        }

        private void child_MouseMove(object sender, MouseEventArgs e)
        {
            if (child != null)
            {
                if (child.IsMouseCaptured)
                {
                    var tt = GetTranslateTransform(child);
                    Vector v = start - e.GetPosition(this);
                    tt.X = origin.X - v.X;
                    tt.Y = origin.Y - v.Y;
                }
            }
        }
        private int shag = 100;
        private void SaveAsPicture_Click(object sender, RoutedEventArgs e)
        {
            //Size size = child.Child.RenderSize;
            //RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap((int)size.Width, (int)size.Height, 96, 96, PixelFormats.Pbgra32);
            //renderTargetBitmap.Render(child.Child);
            //PngBitmapEncoder pngImage = new PngBitmapEncoder();
            //pngImage.Frames.Add(BitmapFrame.Create(renderTargetBitmap));
            //using (Stream fileStream = File.Create("nam1.png"))
            //{
            //    pngImage.Save(fileStream);
            //}
            //Canvas canvas = (Canvas)child.Child;
            //Label lb = new Label();
            //lb.Width = 50;
            //lb.Height = 50;
            //lb.Content = "NLABEL";
            ////Canvas.SetTop(lb, Canvas.GetTop(centerLB) - shag);
            //canvas.Children.Add(lb);
            //shag += 50;
        }

        private void CreateNewProject_Click(object sender, RoutedEventArgs e)
        {
            PersonViewModel lb = new PersonViewModel();
            lb.Content = "LABEL";
            lb.Width = 50;
            lb.Height = 50;
            Canvas.SetLeft(lb, viewController.Center.X - lb.Width / 2);
            Canvas.SetTop(lb, viewController.Center.Y - lb.Height / 2);
            viewController.AddElement(lb);
            Debug.WriteLine(Canvas.GetLeft(lb));
            Debug.WriteLine(Canvas.GetTop(lb));

            //Debug.WriteLine(ViewController.Center);
            //viewController.Height += 100;
            //Debug.WriteLine(ViewController.Center);
            //viewController.Width += 100;
            //Debug.WriteLine(ViewController.Center);
        }
    }
}
