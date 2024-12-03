using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace mvvmApplication.ViewModedl
{
    internal partial class VMNewPage : ObservableObject
    {
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private string _isOk;
        public string Name
        {
            get => _name;
            set => SetPropertyValue(ref _name, value);
        }
        public string IsOk
        {
            get => _isOk;
            set => SetPropertyValue(ref _isOk, value);
        }

        private void SetPropertyValue(ref string name, string value)
        {
            throw new NotImplementedException();
        }

        public VMNewPage() { 
            Name = "ali";
        }
        
    }
}
