using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecordKeeperBizObjects
{
    public class bizParty : bizObject<bizParty>
    {
        string partynameval = "";
        string colorval = "";
        int yearstartedval = 0;
        int presidentcountval = 0;
        List<bizPresident> lstpresident;
        public bizParty()
        {
        }

        public int PartyId { get => this.PrimaryKeyValue; set => this.PrimaryKeyValue = value; }
        [Required]
        [Display(Name ="Party Name")]
        public string PartyName
        {
            get
            {
                return partynameval;
            }
            set
            {
                partynameval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        [Display(Name = "Year Started")]
        public int YearStarted
        {
            get
            {
                return yearstartedval;
            }
            set
            {
                yearstartedval = value;
                InvokePropertyChanged();
            }
        }
        public int PresidentCount
        {
            get
            {
                return presidentcountval;
            }
            set
            {
                presidentcountval = value;
                InvokePropertyChanged();
            }
        }
        [Required]
        public string Color
        {
            get
            {
                return colorval;
            }
            set
            {
                colorval = value;
                InvokePropertyChanged();
            }
        }
        public List<bizPresident> PresidentList(bool refresh)
        {
            if (refresh==true || lstpresident == null)
            {
                lstpresident = bizPresident.GetList("PartyName", this.PartyName);
            }
            return lstpresident;
        }
    }
}
