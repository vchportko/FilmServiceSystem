using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmServiceSystem.Model;
using System.Windows.Forms;
using System.Drawing;

namespace FilmServiceSystem.FormServices
{
    public static class FormServices
    {
        #region Fields
        public static DataGridView FilmsDataGridView;
        public static DataGridView OrderDataGridView;
        public static List<FilmInfo> availableFilms;
        public static TextBox orderFilm;
        public static Label orderPrice;
        #endregion

        #region Methods
        public static void AddFilmsToListView(List<FilmInfo> list)
        {
            if(FilmsDataGridView.Rows.Count!=0)
            {
                FilmsDataGridView.Rows.Clear();
            }
            for (int i = 0; i < list.Count; i++)
            {
                string[] item = { list[i].Title, list[i].IMDb.ToString(), list[i].Genre, list[i].YearRelease.ToString(), list[i].DirectorName, list[i].Price.ToString() };
                FilmsDataGridView.Rows.Add(item);
                if( availableFilms.Count(f => f.Title == list[i].Title) ==0 )
                {
                    FilmsDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }

            }
        }

        public static void AddOrdersToListView(List<OrderInfo> list)
        {
            if (OrderDataGridView.Rows.Count != 0)
            {
                OrderDataGridView.Rows.Clear();
            }
            for (int i = 0; i < list.Count; i++)
            {
                string[] item = {list[i].Login,list[i].FilmTitle, list[i].FilmPrice.ToString(),list[i].OrderDate };
                OrderDataGridView.Rows.Add(item);

            }
        }
        #endregion

    }
}
