using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using WPFDynamicColumn.Model;
using System.Collections.ObjectModel;
using System.Timers;
using System.Windows;

namespace WPFDynamicColumn.ViewModel
{
    public class MainViewModel :ViewModelBase
    {
        private static System.Timers.Timer MedicationTimer;

        private ObservableCollection<MedicationDetail> _medicationDetailList;

        public ObservableCollection<MedicationDetail> MedicationDetailList
        {
            get { return _medicationDetailList; }
            set { _medicationDetailList = value; RaisePropertyChanged(nameof(MedicationDetailList)); }
        }


        public MainViewModel()
        {
            MedicationDetailList = new ObservableCollection<MedicationDetail>();
            MedicationTimer = new Timer(10000);
            MedicationTimer.Elapsed += OnMedicationTimerCallBack;
            MedicationTimer.AutoReset = true;
            MedicationTimer.Enabled = true;
        }

        

        private void OnMedicationTimerCallBack(object sender, ElapsedEventArgs e)
        {

            if (MedicationDetailList == null)
                MedicationDetailList = new ObservableCollection<Model.MedicationDetail>();

            var MedicationDetail = new Model.MedicationDetail();
            MedicationDetail.MedicationTime = DateTime.Now.ToString("HH:mm");
            MedicationDetail.Medication1 = new Model.Medication() { MedicationId = 1, MedicationRate = 45, MedicationVolInfused = 10, MedicationVolRemaning = 30 };
            MedicationDetail.Medication2 = new Model.Medication() { MedicationId = 2, MedicationRate = 45, MedicationVolInfused = 10, MedicationVolRemaning = 30 };
            MedicationDetail.Medication3 = new Model.Medication() { MedicationId = 3, MedicationRate = 45, MedicationVolInfused = 10, MedicationVolRemaning = 30 };

            Application.Current.Dispatcher.Invoke(() => {
                MedicationDetailList.Add(MedicationDetail);
            });
        }
    }
}
