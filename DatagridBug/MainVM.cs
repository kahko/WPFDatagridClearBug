using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace DatagridBugNETFramework
{
    public class MainVM
    {
        public ObservableCollection<A> Collection { get; } = new ObservableCollection<A>();

        private ICommand _clearCommand;
        public ICommand ClearCommand
        {
            get
            {
                if (_clearCommand is null)
                    _clearCommand = new RelayCommand(_ => Collection.Clear(), _ => Collection.Any());
                return _clearCommand;
            }
        }
    }

    public class A
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
