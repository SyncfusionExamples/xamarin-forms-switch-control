using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfSwitchDemo
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        #region private fields

        /// <summary>
        /// The set state field.
        /// </summary>
        bool setState = false;

        /// <summary>
        /// The is on field.
        /// </summary>
        bool isOn = true;


        #endregion

        #region Constructor
        public MainPage()
        {
            InitializeComponent();
            if (Device.RuntimePlatform == Device.iOS)
            {
                mainStack.WidthRequest = 500;
            }
        }

        #endregion

        #region methods

        /// <summary>
        /// The state changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfSwitch_StateChanged(object sender, EventArgs e)
        {

            this.OnStateLabel.Text = GetLabel(this.OnStateSwitch.IsOn);
            setStates(true, this.OnStateSwitch.IsOn);
        }

        /// <summary>
        /// The state changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfSwitch_StateChanged_1(object sender, EventArgs e)
        {

            this.IndeterminateStateLabel.Text = GetLabel(this.IndeterminateStateSwitch.IsOn);
            setStates(null, this.IndeterminateStateSwitch.IsOn);
        }

        /// <summary>
        /// The state changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfSwitch_StateChanged_2(object sender, EventArgs e)
        {

            this.OffStateLabel.Text = GetLabel(this.OffStateSwitch.IsOn);
            setStates(false, this.OffStateSwitch.IsOn);
        }

        /// <summary>
        /// The get label method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private string GetLabel(bool? value)
        {
            if (value == true)
                return "On";
            else if (value == false)
                return "Off";
            else
                return "Indeterminate";
        }

        /// <summary>
        /// The set states method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void setStates(bool? value, bool? state)
        {
            if (setState)
                return;
            setState = true;

            if (value == true)
            {
                if (state == true)
                {
                    this.IndeterminateStateSwitch.IsOn = null;
                    this.OffStateSwitch.IsOn = false;
                }
                else if (state == false)
                {
                    this.IndeterminateStateSwitch.IsOn = null;
                    this.OffStateSwitch.IsOn = true;
                }
                else
                {
                    this.IndeterminateStateSwitch.IsOn = false;
                    this.OffStateSwitch.IsOn = true;
                }

            }
            else if (value == false)
            {
                if (state == true)
                {
                    this.IndeterminateStateSwitch.IsOn = null;
                    this.OnStateSwitch.IsOn = false;
                }
                else if (state == false)
                {
                    this.IndeterminateStateSwitch.IsOn = null;
                    this.OnStateSwitch.IsOn = true;
                }
                else
                {
                    this.IndeterminateStateSwitch.IsOn = false;
                    this.OnStateSwitch.IsOn = true;
                }
            }
            else
            {
                if (state == true)
                {
                    this.OnStateSwitch.IsOn = null;
                    this.OffStateSwitch.IsOn = false;
                }
                else if (state == false)
                {
                    this.OnStateSwitch.IsOn = true;
                    this.OffStateSwitch.IsOn = null;
                }
                else
                {
                    this.OnStateSwitch.IsOn = true;
                    this.OffStateSwitch.IsOn = false;
                }
            }

            await Task.Delay(500);
            setState = false;
        }

        /// <summary>
        /// The state changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SfSwitch_StateChanged_3(object sender, EventArgs e)
        {
            if (this.ModeSwitch.IsOn == true)
                this.ModeLabel.Text = "Night mode enabled";
            else
                this.ModeLabel.Text = "Day mode enabled";
        }

        /// <summary>
        /// The state changing method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SfSwitch_StateChanging(object sender, System.ComponentModel.CancelEventArgs e)
        {

            this.busySwitch1.IsBusy = true;
            await Task.Delay(2000);
            this.busySwitch1.IsOn = isOn;
            this.busySwitch1.IsBusy = false;
            isOn = !isOn;
        }

        /// <summary>
        /// The state changed method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SfSwitch_StateChanging_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.busySwitch2.IsBusy = true;
            await Task.Delay(2000);
            this.busySwitch2.IsOn = false;
            this.busySwitch2.IsBusy = false;
        }

        #endregion
    }
}
