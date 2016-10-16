using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmServiceSystem.DAL.Concrete.Repositories;
using System.Configuration;
using FilmServiceSystem.Model;
using FilmServiceSystem.FormServices;
using FilmServiceSystem.DAL.Concrete.UnitOfWork;


namespace FilmServiceSystem
{
    public partial class MainForm : Form
    {
        UnitOfWork uow;
        public MainForm()
        {
            InitializeComponent();     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogLabel.Text = CurrentUser.Login;
            NameLabel.Text = CurrentUser.FirstName;
            SurnameLabel.Text = CurrentUser.LastName;
            BalanceLabel.Text = CurrentUser.Balance.ToString();
            uow = new UnitOfWork(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            FormServices.FormServices.FilmsDataGridView = filmsDGV;
            FormServices.FormServices.OrderDataGridView = userHistoryDGV;
            FormServices.FormServices.availableFilms = uow.FilmRepository.getAvailableFilm();
        }


        private void IMDb_Pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByIMDb());
        }
 
        private void action_pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByGenre("Action"));
        }

        private void adventure_pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByGenre("Adventure"));
        }

        private void biography_pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByGenre("Biography"));
        }

        private void crime_pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByGenre("Crime"));
        }

        private void drama_pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByGenre("Drama"));
        }

        private void thriller_pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByGenre("Thriller"));
        }

        private void fantasy_pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByGenre("Fantasy"));
        }

        private void horror_pb_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getSortedFilmByGenre("Mystery"));
        }

        private void backPB_Click(object sender, EventArgs e)
        {
            optionPanel.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sortingPanel.BringToFront();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            //swapping datagridview and children`s panels
            swapDataGridView(0, 1);
            var sortIndex= flowLayoutPanel1.Controls.IndexOf(sortingPanel);
            var optionIndex = flowLayoutPanel1.Controls.IndexOf(optionPanel);
            flowLayoutPanel1.Controls.SetChildIndex(sortingPanel, optionIndex);
            flowLayoutPanel1.Controls.SetChildIndex(optionPanel, sortIndex);
        }
        
        private void OrderButton_Click(object sender, EventArgs e)
        {
            //swapping datagridview and children`s panels
            swapDataGridView(0, 1);
            var orderIndex = flowLayoutPanel1.Controls.IndexOf(OrderPanel);
            var optionIndex = flowLayoutPanel1.Controls.IndexOf(optionPanel);
            flowLayoutPanel1.Controls.SetChildIndex(OrderPanel, optionIndex);
            flowLayoutPanel1.Controls.SetChildIndex(sortingPanel, orderIndex);
        }

        private void back2PB_Click(object sender, EventArgs e)
        {
            optionPanel.BringToFront();
        }

        private void pHistroyLabel_Click(object sender, EventArgs e)
        {
            swapDataGridView(1, 0);
            FormServices.FormServices.AddOrdersToListView(uow.OrderRepository.getOrderHistoryOfUser(CurrentUser.ID));
        }

        private void swapDataGridView(int filmsID,int userHistoryID)
        {
            DataGridLayoutPanel.Controls.SetChildIndex(panelLayout1, userHistoryID);
            DataGridLayoutPanel.Controls.SetChildIndex(panelLayout2, filmsID);
        }

        private void userHistoryDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void availableButton_Click(object sender, EventArgs e)
        {
            swapDataGridView(0, 1);
            FormServices.FormServices.AddFilmsToListView(uow.FilmRepository.getAvailableFilm());
        }

        // log out action
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CurrentUser.Balance = 0;
            CurrentUser.FirstName = "";
            CurrentUser.LastName = "";
            CurrentUser.ID = -1;
            CurrentUser.Login = "";
            this.Hide();
            (new LogForm()).ShowDialog();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (orderFilm.Text.Length > 0)
            {
                string orderDate = DateTime.Today.ToString();
                List<Film> films = new List<Film>(uow.FilmRepository.getSortedFilmByIMDb());
                // find filn id of ordered film
                int FilmID = (from f in films
                                  where f.Title == orderFilm.Text
                                  select f.ID).First();
                if(uow.OrderRepository.MakeOrder(CurrentUser.ID, FilmID, orderDate) == 0)
                {
                    MessageBox.Show("You haven`t enough money");
                }
                CurrentUser.Balance = uow.UserRepository.GetBalance(CurrentUser.ID);
                BalanceLabel.Text = CurrentUser.Balance.ToString();
            }
            FormServices.FormServices.availableFilms = uow.FilmRepository.getAvailableFilm();
        }

        private void filmsDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (filmsDGV.SelectedRows.Count > 0)
            {
                string title = filmsDGV.SelectedRows[0].Cells["title"].Value.ToString();
                bool isAvailable = FormServices.FormServices.availableFilms.Count(f => f.Title == title) != 0;
                if ((filmsDGV.SelectedRows.Count != 0) && isAvailable)
                {
                    orderFilm.Text = title;
                    orderPrice.Text = filmsDGV.SelectedRows[0].Cells["price"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Unfortuantly this film was sold , please choose another");
                }
            }
        }
    }
}
