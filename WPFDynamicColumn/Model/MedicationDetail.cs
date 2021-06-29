using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WPFDynamicColumn.Model
{
    public class MedicationDetail :ViewModelBase
    {
        public string MedicationTime { get; set; }

        private Medication _medication1;
        public Medication Medication1
        {
            get { return _medication1; }
            set { _medication1 = value; RaisePropertyChanged(nameof(Medication1)); }
        }

        private Medication _medication2;

        public Medication Medication2
        {
            get { return _medication2; }
            set { _medication2 = value; RaisePropertyChanged(nameof(Medication2)); }
        }


        private Medication _medication3;

        public Medication Medication3
        {
            get { return _medication3; }
            set { _medication3 = value; RaisePropertyChanged(nameof(Medication3)); }
        }


    }
}
