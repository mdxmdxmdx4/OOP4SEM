using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab4_5
{
    public class Command
    {
        private static RoutedUICommand _saveCommand;
        private static RoutedUICommand _loadCommand;
        private static RoutedUICommand _searchCommand;
        private static RoutedUICommand _deleteCommand;
        private static RoutedUICommand _updateCommand;
        private static RoutedUICommand _addCommand;
        private static RoutedUICommand _filterCommand;

        static Command()
        {

            _saveCommand = new RoutedUICommand("Save", "SaveCommand", typeof(Command));
            _loadCommand = new RoutedUICommand("Load", "LoadCommand", typeof(Command));
            _searchCommand = new RoutedUICommand("Search", "SearchCommand", typeof(Command));
            _deleteCommand = new RoutedUICommand("Delete", "DeleteCommand", typeof(Command));
            _updateCommand = new RoutedUICommand("Update", "UpdateCommand", typeof(Command));
            _addCommand = new RoutedUICommand("Add", "AddCommand", typeof(Command));
            _filterCommand = new RoutedUICommand("Filter", "filterCommand", typeof(Command));

        }

        public static RoutedUICommand SaveCommand
        {
            get { return _saveCommand; }
        }

        public static RoutedUICommand LoadCommand
        {
            get { return _loadCommand; }
        }

        public static RoutedUICommand SearchCommand
        {
            get { return _searchCommand; }
        }

        public static RoutedUICommand DeleteCommand
        {
            get { return _deleteCommand; }
        }

        public static RoutedUICommand UpdateCommand
        {
            get { return _updateCommand; }
        }

        public static RoutedUICommand AddCommand
        {
            get { return _addCommand; }
        }

    }
}