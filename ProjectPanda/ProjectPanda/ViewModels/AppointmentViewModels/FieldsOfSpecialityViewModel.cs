using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using ProjectPanda.Models;
using ProjectPanda.Utils;
using ProjectPanda.ViewModels.Base;
using Xamarin.Forms;

namespace ProjectPanda.ViewModels.AppointmentViewModels
{
     public class FieldsOfSpecialityViewModel : BaseViewModel
    {

       public ObservableCollection<Specilization> Specilization { get; set; }

        public FieldsOfSpecialityViewModel()
        {
            GenerateSpecialitiesList();
        }

        

        #region Methods
        void GenerateSpecialitiesList()
        {
            Specilization = new ObservableCollection<Specilization>()
            {
                 new Specilization{ Name=FieldsOfExpiertiseConstants.audiologist, FieldIcon=FieldsOfExpiertiseConstants.audiologyIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.bioKineticist, FieldIcon=FieldsOfExpiertiseConstants.bioKineticistIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.cardiologist, FieldIcon=FieldsOfExpiertiseConstants.cardioIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.chiropractor, FieldIcon=FieldsOfExpiertiseConstants.chiropractorIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.clicincalPsychologist, FieldIcon=FieldsOfExpiertiseConstants.clinicalIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.dentalSurgeon, FieldIcon=FieldsOfExpiertiseConstants.dentalSurgeryIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.dentist, FieldIcon=FieldsOfExpiertiseConstants.dentalSurgeryIcon2},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.dermatologist, FieldIcon=FieldsOfExpiertiseConstants.dermatologistIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.dietician, FieldIcon=FieldsOfExpiertiseConstants.dieticianIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.eNT_Specilist, FieldIcon=FieldsOfExpiertiseConstants.eNT_SpecilistIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.gp, FieldIcon=FieldsOfExpiertiseConstants.gpIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.gynaecologist, FieldIcon=FieldsOfExpiertiseConstants.gynaecologistIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.haematology, FieldIcon=FieldsOfExpiertiseConstants.haematologyIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.nerosurgeon, FieldIcon=FieldsOfExpiertiseConstants.neuroIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.oncologist, FieldIcon=FieldsOfExpiertiseConstants.OncologyIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.optometrist, FieldIcon=FieldsOfExpiertiseConstants.optomotristIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.OrthopedicSurgeon, FieldIcon=FieldsOfExpiertiseConstants.OrthopaedicSurgeonIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.paediatrician, FieldIcon=FieldsOfExpiertiseConstants.paediatricianIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.physiotherapist, FieldIcon=FieldsOfExpiertiseConstants.physiotherapistIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.plasticSurgeon, FieldIcon=FieldsOfExpiertiseConstants.plasticIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.psychiatrist, FieldIcon=FieldsOfExpiertiseConstants.psychiatristIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.radiologist, FieldIcon=FieldsOfExpiertiseConstants.radiologistIcon},
                 new Specilization{ Name=FieldsOfExpiertiseConstants.urologist, FieldIcon=FieldsOfExpiertiseConstants.urologistIcon}
                 
            };
        }
        #endregion

    }
}
