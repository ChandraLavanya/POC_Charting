using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
namespace WPFDynamicColumn.Model
{
   public class Medication :ViewModelBase
    {
        public int MedicationId { get; set; }
        public int MedicationRate { get; set; }
        public double MedicationVolInfused { get; set; }
        public int MedicationVolRemaning { get; set; }
    }
}
