using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using FamilyTree.DI;

namespace FamilyTree.UI
{
    /// <summary>
    /// Класс визаульного представления узла генеалогического древа
    /// </summary>
    public class PersonViewModel : ContentControl
    {
        public IPerson Model { get; set; }
    }
}
