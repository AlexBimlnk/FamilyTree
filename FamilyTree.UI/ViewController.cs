using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using FamilyTree.DI;

namespace FamilyTree.UI
{
    public class ViewController : Canvas
    {
        public Point Center { get; set; }

        //Нужно будет сделать свзяь через интерфейс модели представления, но пока будем использовать
        //обычную модель, чтобы понять какие свойства нам понадобятся
        //Т.е в будущем заменить PersonViewModel -> IViewModel

        public PersonViewModel Root { get; set; }

        //private int shift

        public ViewController()
        {
            Center = new Point((int)Width / 2, (int)Height / 2);
            SizeChanged += OnSizeChanged;
        }

        public void AddElement(PersonViewModel viewModel)
        {
            if(Root is null)
                Root = viewModel;
            Children.Add(viewModel);
        }

        private void SizeCorrection(UIElement element)
        {

        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            ViewController viewController = sender as ViewController;
            Center = new Point((int)viewController.Width / 2, (int)viewController.Height / 2);
        }
    }
}
