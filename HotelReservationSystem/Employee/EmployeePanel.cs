using HotelReservationSystem.PresenterCommons;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationSystem.Employee
{
    public partial class EmployeePanel : UserControl
    {
        private PresenterEmployeePanel _presenter;

        public PresenterEmployeePanel Presenter
        {
            get { return _presenter; }
        }

        public EmployeePanel()
        {
            InitializeComponent();
            _presenter = new PresenterEmployeePanel();
            _presenter.PopulateGridView(EmployeeGridView);
        }
    }

    public interface IPresenterEmployeePanel : IPresenter 
    { 
        DataTable Data { get; }
    }

    public class PresenterEmployeePanel : INotifyPropertyChanged, IPresenter
    {
        private Form _form;
        private Panel _panel;
        private DataTable _dataTable;
        private string _connection = Constants.MySqlConstants.Connection;

        public Form Form 
        { 
            get { return _form; }
            set { _form = value; }
        }

        public Panel Panel
        {
            get { return _panel; }
            set { _panel = value; }
        }

        public DataTable DataTable
        {
            get { return _dataTable;}
        }

        public void PopulateGridView(DataGridView dataGrid)
        {
            if (_dataTable == null)
            {
                _dataTable = new DataTable();
            }
            string query = "select * from admin";
            MySqlConnection mySqlConnection = new MySqlConnection(_connection);
            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(_dataTable);

            dataGrid.DataSource = _dataTable;
            mySqlConnection.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
