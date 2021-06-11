using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSOWNHodinyCircularProgressBar
{
    public partial class HodinyCircularProgressBarForm : Form
    {
        public HodinyCircularProgressBarForm()
        {
            InitializeComponent();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string mesicText,
                   tydenText,
                   hodinyText,
                   sekundyText,
                   minutyText;
            int tydenValue;

            switch (DateTime.Now.Second)
            {
                case 0:
                    sekundyText = "sekund";
                    break;
                case 1:
                    sekundyText = "sekunda";
                    break;
                case 2:
                case 3:
                case 4:
                    sekundyText = "sekundy";
                    break;
                default:
                    sekundyText = "sekund";
                    break;
            }

            switch (DateTime.Now.Minute)
            {
                case 0:
                    minutyText = "minut";
                    break;
                case 1:
                    minutyText = "minuta";
                    break;
                case 2:
                case 3:
                case 4:
                    minutyText = "minuty";
                    break;
                default:
                    minutyText = "minut";
                    break;
            }

            switch (DateTime.Now.Hour)
            {
                case 0:
                    hodinyText = "hodin";
                    break;
                case 1:
                    hodinyText = "hodina";
                    break;
                case 2:
                case 3:
                case 4:
                    hodinyText = "hodiny";
                    break;
                default:
                    hodinyText = "hodin";
                    break;
            }

            switch (DateTime.Now.Month)
            {
                case 1:
                    mesicText = "ledna";
                    break;
                case 2:
                    mesicText = "února";
                    break;
                case 3:
                    mesicText = "března";
                    break;
                case 4:
                    mesicText = "dubna";
                    break;
                case 5:
                    mesicText = "května";
                    break;
                case 6:
                    mesicText = "června";
                    break;
                case 7:
                    mesicText = "července";
                    break;
                case 8:
                    mesicText = "srpna";
                    break;
                case 9:
                    mesicText = "září";
                    break;
                case 10:
                    mesicText = "října";
                    break;
                case 11:
                    mesicText = "listopadu";
                    break;
                default:
                    mesicText = "prosince";
                    break;
            }

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                    tydenText = "neděle";
                    tydenValue = 7;
                    break;
                case DayOfWeek.Monday:
                    tydenText = "pondělí";
                    tydenValue = 1;
                    break;
                case DayOfWeek.Tuesday:
                    tydenText = "úterý";
                    tydenValue = 2;
                    break;
                case DayOfWeek.Wednesday:
                    tydenText = "středa";
                    tydenValue = 3;
                    break;
                case DayOfWeek.Thursday:
                    tydenText = "čtvrtek";
                    tydenValue = 4;
                    break;
                case DayOfWeek.Friday:
                    tydenText = "pátek";
                    tydenValue = 5;
                    break;
                default:
                    tydenText = "sobota";
                    tydenValue = 6;
                    break;
            }

            hodinyCircularProgressBar.Value = DateTime.Now.Hour;
            hodinyCircularProgressBar.Text = string.Format("{0} {1}", DateTime.Now.Hour, hodinyText);

            minutyCircularProgressBar.Value = DateTime.Now.Minute;
            minutyCircularProgressBar.Text = string.Format("{0} {1}", DateTime.Now.Minute, minutyText);

            sekundyCircularProgressBar.Value = DateTime.Now.Second;
            sekundyCircularProgressBar.Text = string.Format("{0} {1}", DateTime.Now.Second, sekundyText);

            // den v měsíci
            denCircularProgressBar.Value = DateTime.Now.Day;
            denCircularProgressBar.Text = string.Format("{0}.", DateTime.Now.Day);

            // den v týdnu
            dnyCircularProgressBar.Text = string.Format("{0}", tydenText);
            dnyCircularProgressBar.Value = tydenValue;

            mesicCircularProgressBar.Value = DateTime.Now.Month;
            mesicCircularProgressBar.Text = string.Format("{0}", mesicText);

            rokCircularProgressBar.Value = DateTime.Now.Year;
            rokCircularProgressBar.Text = string.Format("{0}", DateTime.Now.Year);
        }
    }
}
