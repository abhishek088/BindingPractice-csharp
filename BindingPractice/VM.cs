//Author: Abhishek Sawant, 8683623
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingPractice
{
    enum choices
    {
        NoChoice = -1,
        One,
        Two,
        Three,
        Four
    }
    class VM : INotifyPropertyChanged
    {
        public void CheckButton()
        {
            OutputList.Clear();

            if (CheckTextBox != "")
                OutputList.Add("Text Box is not empty");

            if (CheckCheckBox == true)
                OutputList.Add("Check Box is checked");

            if (CheckRadioButton == true)
                OutputList.Add("Radio Button is checked");

            if (CheckCheckBox == true && CheckRadioButton == true)
            {
                CheckLabel = "Activated Label";
                OutputList.Add("Label is not empty");
            }

            switch (Index)
            {
                case choices.One:
                    OutputList.Add("Number 1 was selected");
                    break;
                case choices.Two:
                    OutputList.Add("Number 2 was selected");
                    break;
                case choices.Three:
                    OutputList.Add("Number 3 was selected");
                    break;
                case choices.Four:
                    OutputList.Add("Number 4 was selected");
                    break;
                default:
                    break;
            }
        }

        public void ClearButton()
        {
            OutputList.Clear();
            CheckCheckBox = false;
            CheckRadioButton = false;
            CheckLabel = "";
            CheckTextBox = "";
        }

        #region Properties
        private string checkTextBox = "";
        public string CheckTextBox
        {
            get { return checkTextBox; }
            set { checkTextBox = value; notifyChange(); }
        }

        private bool checkCheckBox = false;
        public bool CheckCheckBox
        {
            get { return checkCheckBox; }
            set { checkCheckBox = value; notifyChange(); }
        }

        private bool checkRadioButton = false;
        public bool CheckRadioButton
        {
            get { return checkRadioButton; }
            set { checkRadioButton = value; notifyChange(); }
        }

        private string checkLabel = "";
        public string CheckLabel
        {
            get { return checkLabel; }
            set { checkLabel = value; notifyChange(); }
        }

        private choices index = choices.NoChoice;

        public choices Index
        {
            get { return index; }
            set { index = value; notifyChange(); }
        }
        #endregion

        #region PropertyChanged
        public ObservableCollection<String> OutputList { get; set; } = new ObservableCollection<String>();

        public event PropertyChangedEventHandler PropertyChanged;

        private void notifyChange([CallerMemberName] String PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        #endregion
    }
}
