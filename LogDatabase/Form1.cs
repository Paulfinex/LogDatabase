using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogDatabase
{
    public partial class LogDB : Form
    {
        
        public LogDB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load data from the SQLite DB at the start of the program
            LoadData();
        }
        //private string csvPath;
        private string exportPath;
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        List<string> filenames = new List<string>();
        //This list is not used, the Log class contains the structure of the database and allows to iterate records using this list if it is needed.
        List<Log> logs = new List<Log>();


        //SQLite Handling _____________________________________________________________________________________________________
        //Set connection to the SQLite DB, the connection string is inf App.Config, Configuration Manager is used to pull the configuration from the App.config file
        private void SetConnection()
        {
            sql_con = new SQLiteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
        }
        //Used to execute a query
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        //Load all the data of the SQLite DB in the GridView
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from log;";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }


        //Update GridView, reload records from the SQLite DB __________________________________________________________________
        private void btn_display_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        //Button to open the file select dialog________________________________________________________________________________
        private void btn_selectDialog_Click(object sender, EventArgs e)
        {
            importDialog.Title = "Seleziona file CSV da importare.";
            importDialog.ShowDialog();
            foreach (string file in importDialog.FileNames)
            {
                filenames.Add(file);
            }
           // txtbox_import.Text = importDialog.FileName;
           //csvPath = importDialog.FileName;
        }


        //Button to call the Background worker thread used to import a CSV file into the SQLite DB_____________________________
        private void btn_import_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }


        //Search in the SQLite DB______________________________________________________________________________________________
        //All the logic for the search is handled by the button "cerca", this could be handled by an additional background worker allowing for multithreading if the search 
        //  becomes slow with increasing data size
        private void btn_cerca_Click(object sender, EventArgs e)
        {   
            //Put the values from textboxes in variables
            string Number = txtbox_number.Text;
            string Type = txtbox_type.Text;
            string Date = txtbox_date.Text;
            string Time = txtbox_time.Text;
            string User = txtbox_user.Text;
            string Source_IP = txtbox_sourceip.Text;
            string Computer_name = txtbox_computername.Text;
            string Connection_type = txtbox_connectiontype.Text;
            string Accessed_resources = txtbox_accessedres.Text;
            string Action = txtbox_action.Text;
            //Create a string builder to concatenate all the strings to generate the query
            string searchStr = "";
            //For each variable, check if it is empty, if not add the query portion to the string builder
            if (Number != "") { searchStr = searchStr + "Number like '%" + Number + "%' and "; }
            if (Type != "") { searchStr = searchStr + "Type like '%" + Type + "%' and "; }
            if (Date != "") { searchStr = searchStr + "Date like '%" + Date + "%' and "; }
            if (Time != "") { searchStr = searchStr + "Time like '%" + Time + "%' and "; }
            if (User != "") { searchStr = searchStr + "User like '%" + User + "%' and "; }
            if (Source_IP != "") { searchStr = searchStr + "Source_IP like '%" + Source_IP + "%' and "; }
            if (Computer_name != "") { searchStr = searchStr + "Computer_name like '%" + Computer_name + "%' and "; }
            if (Connection_type != "") { searchStr = searchStr + "Connection_type like '%" + Connection_type + "%' and "; }
            if (Accessed_resources != "") { searchStr = searchStr + "Accessed_resources like '%" + Accessed_resources + "%' and "; }
            if (Action != "") { searchStr = searchStr + "Action like '%" + Action + "%' and "; }
            //Check if the string builder is empty
            if (searchStr != "")
            {
                //Concatenate the string builder with a select statement
                string querySrc = "select * from log where " + searchStr;
                //Remove the last 4 characters from the query ( "and ")
                querySrc = querySrc.Substring(0, querySrc.Length - 4);
                //Initiate connection with the DB and replace the content of the GridView ( Note: the follow sequence of commands is the same as the function LoadData()
                //  only with a different query, a general function with a query input was not used since the purpose of the LoadData function is mainly to refresh/load
                //  the whole DB in the GridView
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                DB = new SQLiteDataAdapter(querySrc, sql_con);
                DS.Reset();
                DB.Fill(DS);
                DT = DS.Tables[0];
                dataGridView1.DataSource = DT;
                sql_con.Close();
            }
            else
            {
                MessageBox.Show("Inserire uno o piu' campi per la ricerca.", "Ricerca fallita", MessageBoxButtons.OK);
            }
        }


        //Export the current data shown in the GridView to a CSV file__________________________________________________________
        private void btn_exp_Click(object sender, EventArgs e)
        {
            //Check if the BackGround Worker is busy with another export
            if (backgroundWorker2.IsBusy)
            {
                MessageBox.Show("Stai già esportando un file, attendi il completamento.");
                return;
            }
            //Oped the save file dialog
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //Save the desired path of the file to be exported
                    exportPath = sfd.FileName;
                }
            
            }
            //Check if the background worker is free
            if (!backgroundWorker2.IsBusy)
            {
                //Call the Do_Work function of the background worker
                backgroundWorker2.RunWorkerAsync();
            }


        }
 

        //Background Worker for the CSV File Import____________________________________________________________________________
        //Operations performed by the background worker, this function is called by | backgroundWorker1.RunWorkerAsync(); | from the import button
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //index used to count the progress from each loop
            int index = 1;
            //row count of the csv to import
            var totLine = 0;
            foreach (string f in filenames)
            {
                totLine = totLine + System.IO.File.ReadAllLines(f).Length;
            }
            foreach (string csvPath in filenames)
            {
                //counter used to skip the first line of the file ( Header of the CSV)
                var lineN = 0;
                //Get the filename from the full path of the file
                var fileName = Path.GetFileName(csvPath);
                //Initiating the streamreader to get data from file
                using (StreamReader reader = new StreamReader(csvPath))
                {
                    //Loop until end of file (EOF)
                    while (!reader.EndOfStream)
                    {
                        //Store current line extracted from the file
                        var line = reader.ReadLine();
                        //Calculate the percentage of the total progress
                        //( Note: in C# double and float cannot be used to calculate percentage since the decimal value will be truncated and will always be put to 0
                        //  use decimal if there is need to add new progress checks)
                        decimal c = ((decimal)index / totLine) * 100;
                        //Send the current progress of the operation to the background worker ProgressChanged event
                        backgroundWorker1.ReportProgress(Decimal.ToInt32(c));
                        index++;
                        //Check if it is the first line of the file, if true then skip
                        try
                        {
                            if (lineN != 0)
                            {
                                //Replace all ' with '' , in SQL '' is used to ignore a single quote (') in a query, since the logs contain multiple quotes used as accentation
                                //  this was needed to import them without cutting records
                                var temp = line.Replace("'", "''");
                                //Split records at each , Split generates a list of values that can be accessed as an Array ( see next line )
                                var values = temp.Split(',');
                                //Create a query for each line including all the values + the filename
                                var cmd = "INSERT INTO Log VALUES (" + values[0] + ",'" + values[1] + "','" + values[2] + "','" + values[3] + "','" + values[4] + "','" + values[5] +
                                                               "','" + values[6] + "','" + values[7] + "','" + values[8] + "','" + values[9] + "','" + fileName + "')";
                                //Calls the function to handle the SQLite connection and execute the query

                                ExecuteQuery(cmd);

                            }
                        }
                        catch (SQLiteException sqle)
                        {
                            MessageBox.Show("Errore nell'importazione: " + sqle, "Errore Importazione", MessageBoxButtons.OK);
                        }
                        lineN++;

                    }
                }
            }

        }
        //Send a progress update message to the main thread, updating the progress bar and lable.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progBar_import.Visible = true;
            lbl_progresso.Visible = true;
            progBar_import.Value = e.ProgressPercentage;
            lbl_progresso.Text = string.Format("In corso... {0}%", e.ProgressPercentage);
            progBar_import.Update();
            //When the work is completed, show a message box and hide the progress UI
            if (progBar_import.Value == 100)
            {
                MessageBox.Show("Completato Import.", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progBar_import.Visible = false;
                lbl_progresso.Visible = false;
            }
        }
        //This was left empty, it can be used to do stuff when a worker is done with its task
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e){}


        //Background Worker for the CSV File Export____________________________________________________________________________
        //Operations performed by the background worker, this function is called by | backgroundWorker2.RunWorkerAsync(); | from the export button
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //Put the current grid data in a new grid
            DataGridView grid = dataGridView1;
            //Declare two variables to keep track of the progress
            int progCount = 1;
            int progMax = grid.RowCount;
            //Check if the grid is empty
            if (grid != null && grid.Columns.Count > 0 && grid.Rows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                //Add column headers row
                sb.AppendLine(GetCommaDelimitedRow(grid, -1));
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    if (!grid.Rows[i].IsNewRow)
                        //Add row data
                        sb.AppendLine(GetCommaDelimitedRow(grid, i));
                    //Calculate progress and send it to the ProgressChanged event
                    decimal c = ((decimal)progCount / progMax) * 100;
                    backgroundWorker2.ReportProgress(Decimal.ToInt32(c));
                    progCount++;
                }
                try
                {
                    //Export the created file
                    File.WriteAllText(exportPath, sb.ToString(), Encoding.UTF8);
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Errore scrittura file: " + e2.Message);
                }
            }
            else
                MessageBox.Show("La griglia è vuota.");

        }
        //Send a progress update message to the main thread, updating the progress bar and lable.
        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progbar_export.Visible = true;
            lbl_prog_export.Visible = true;
            progbar_export.Value = e.ProgressPercentage;
            lbl_prog_export.Text = string.Format("In corso... {0}%", e.ProgressPercentage);
            progbar_export.Update();
            if (progbar_export.Value == 100)
            {
                MessageBox.Show("Esportazione Completata.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progbar_export.Visible = false;
                lbl_prog_export.Visible = false;
            }
        }
        // Extra functions_____________________________________________________________________________________________________

        //Thanks StackOverflow, pretty much just appends values from the grid to generate a string separated by " , "
        private string GetCommaDelimitedRow(DataGridView grid, int rowIndex)
        {
            StringBuilder sb = new StringBuilder();
            for (int curCol = 0; curCol < grid.Columns.Count; curCol++)
            {
                if (rowIndex < 0)
                    sb.Append(grid.Columns[curCol].Name);
                else
                {
                    if (grid.Rows[rowIndex].Cells[curCol].Value != null)
                    {
                        sb.Append(grid.Rows[rowIndex].Cells[curCol].Value.ToString());
                    }
                    else
                    {
                        sb.Append("");
                    }
                }
                // If this col is not the last column... add a delimiter ','
                if (curCol < grid.Columns.Count - 1)
                    sb.Append(",");
            }
            return sb.ToString();
        }

        private void btb_temp_Click(object sender, EventArgs e)
        {

        }
    }

}

     