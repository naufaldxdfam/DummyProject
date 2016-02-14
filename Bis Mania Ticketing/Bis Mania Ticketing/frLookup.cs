using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
namespace Bis_Mania_Ticketing
{
    public partial class frLookup : Form
    {
        BMTDataContext dc = new BMTDataContext();
        Control ctl;
        string LookupFor;
        public int Page { get; set; }
        bool SaveClick =  false;
        int selected = 100;
        public frLookup(Control ctl, string LookupFor)
        {
            InitializeComponent();
            this.ctl = ctl as Control;
            this.LookupFor = LookupFor;
            this.Page = 0;
        }

        private void DisableButton()
        {
            if (dgLookup.SelectedRows.Count < 1)
            {
                bSelect.Enabled = false;
            }
            else
            {
                bSelect.Enabled = true;
            }
        }

        private void LoadGridVenue(int page)
        {
            var get = dc.Venues.Where(i => i.VenueName.Contains(this.tbSearchLookup.Text) || i.VenueLocation.Contains(this.tbSearchLookup.Text))
                        .Select(i => new
                        {
                            ID = i.Id,
                            Name = i.VenueName,
                            Location = i.VenueLocation
                        });

            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;
            int currentpage;

            var loadsource = get.Skip(totalskip).Take(take);
            this.dgLookup.DataSource = loadsource.ToList();

            int totalPage = get.Count() / take;
            int modtotalPage = get.Count() % take;

            if (loadsource.Count() == 0)
            {
                currentpage = 0;
                totalPage = 0;
            }
            else
            {
                currentpage = this.Page + 1;
            }

            if (modtotalPage != 0)
                totalPage += 1;

            lbPage.Text = currentpage.ToString() + " / " + totalPage.ToString();

            if (currentpage <= 1)
                bPrevious.Enabled = false;
            else
                bPrevious.Enabled = true;

            if (currentpage == totalPage)
                bNext.Enabled = false;
            else
                bNext.Enabled = true;
        }

        private void LoadGridOtobus(int page)
        {
            var get = dc.Otobus.Where(x => x.OtobusName.Contains(tbSearchLookup.Text));
            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;

            int currentpage;
            var loadsource = get.Skip(totalskip).Take(take);
            this.dgLookup.DataSource = loadsource.ToList();

            int totalPage = get.Count() / take;
            int modtotalPage = get.Count() % take;

            if (loadsource.Count() == 0)
            {
                currentpage = 0;
                totalPage = 0;
            }
            else
            {
                currentpage = this.Page + 1;
            }

            if (modtotalPage != 0)
                totalPage += 1;

            lbPage.Text = currentpage.ToString() + " / " + totalPage.ToString();

            if (currentpage <= 1)
                bPrevious.Enabled = false;
            else
                bPrevious.Enabled = true;

            if (currentpage == totalPage)
                bNext.Enabled = false;
            else
                bNext.Enabled = true;
        }

        private void LoadGridTicketType(int page)
        {
            var get = dc.TicketTypes.Where(x => x.TicketName.Contains(tbSearchLookup.Text));
            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;

            int currentpage;
            var loadsource = get.Skip(totalskip).Take(take);
            this.dgLookup.DataSource = loadsource.ToList();

            int totalPage = get.Count() / take;
            int modtotalPage = get.Count() % take;

            if (loadsource.Count() == 0)
            {
                currentpage = 0;
                totalPage = 0;
            }
            else
            {
                currentpage = this.Page + 1;
            }

            if (modtotalPage != 0)
                totalPage += 1;

            lbPage.Text = currentpage.ToString() + " / " + totalPage.ToString();

            if (currentpage <= 1)
                bPrevious.Enabled = false;
            else
                bPrevious.Enabled = true;

            if (currentpage == totalPage)
                bNext.Enabled = false;
            else
                bNext.Enabled = true;
        }

        private void LoadGridRoute(int page)
        {
            var get = from r in dc.Routes
                      join dp in dc.Venues
                      on r.RouteDeparture equals dp.Id
                      join ds in dc.Venues
                      on r.RouteDestination equals ds.Id
                      where (dp.VenueName + " (" + dp.VenueLocation + ")").Contains(tbSearchLookup.Text) ||
                      (ds.VenueName + " (" + ds.VenueLocation + ")").Contains(tbSearchLookup.Text) ||
                      (dp.VenueName + " (" + dp.VenueLocation + ")" + "-" + ds.VenueName + " (" + ds.VenueLocation + ")").Contains(tbSearchLookup.Text)
                      select new
                      {
                          r.Id,
                          Departure = dp.VenueName + " (" + dp.VenueLocation + ")",
                          Destination = ds.VenueName + " (" + ds.VenueLocation + ")",
                          RouteDepartureDestination = dp.VenueName + " (" + dp.VenueLocation + ")" + "-" + ds.VenueName + " (" + ds.VenueLocation + ")"
                      };
            if (get.Count() <= selected)
                this.Page = 0;

            int skip = selected;
            int totalskip = page * skip;
            int take = selected;

            int currentpage;
            var loadsource = get.Skip(totalskip).Take(take);
            this.dgLookup.DataSource = loadsource.ToList();

            int totalPage = get.Count() / take;
            int modtotalPage = get.Count() % take;

            if (loadsource.Count() == 0)
            {
                currentpage = 0;
                totalPage = 0;
            }
            else
            {
                currentpage = this.Page + 1;
            }

            if (modtotalPage != 0)
                totalPage += 1;

            lbPage.Text = currentpage.ToString() + " / " + totalPage.ToString();

            if (currentpage <= 1)
                bPrevious.Enabled = false;
            else
                bPrevious.Enabled = true;

            if (currentpage == totalPage)
                bNext.Enabled = false;
            else
                bNext.Enabled = true;
        }

        private void LoadGrid(string lookupfor)
        {
            if (lookupfor == "Venue")
            {
                LoadGridVenue(this.Page);
            }
            else if (lookupfor == "Otobus")
            {
                LoadGridOtobus(this.Page);
            }
            else if (lookupfor == "TicketType")
            {
                LoadGridTicketType(this.Page);
            }
            else if (lookupfor == "Route")
            {
                LoadGridRoute(this.Page);
            }

            DisableButton();
        }

        private void frLookup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.SaveClick)
                this.ctl.Text = dgLookup.CurrentRow.Cells[0].Value.ToString();
        }

        private void tbSearchLookup_ButtonClick(object sender, EventArgs e)
        {
            this.Page = 0;
            LoadGrid(this.LookupFor);
        }

        private void bSelect_Click(object sender, EventArgs e)
        {
            this.SaveClick = true;
            this.Close();
        }

        private void dgLookup_DoubleClick(object sender, EventArgs e)
        {
            if (dgLookup.SelectedRows.Count != 0)
            {
                bSelect_Click(sender, e);
            }            
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            this.Page += 1;
            LoadGrid(this.LookupFor);
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            this.Page -= 1;
            LoadGrid(this.LookupFor);
        }

        private void dgLookup_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int x = 1;
            int y = dgLookup.Columns.Count;
            foreach (DataGridViewColumn i in dgLookup.Columns)
            {
                if (this.LookupFor == "Route")
                {
                    if (x <= y)
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    x++;
                }
                else
                {
                    if (x < y)
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    else
                        i.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    x++;
                }
            }
            dgLookup.AutoResizeColumns();
        }
    }
}
