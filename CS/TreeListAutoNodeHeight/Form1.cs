using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TreeListAutoNodeHeight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            treeList1.DataSource = CreateDataset_Table().Tables["Customers"];
            CustomAnyControlEditRepositoryItem CustomRepository = new CustomAnyControlEditRepositoryItem();
            treeList1.OptionsBehavior.AutoNodeHeight = true;
            treeList1.RepositoryItems.Add(CustomRepository);
            treeList1.Columns["string"].ColumnEdit = CustomRepository;
        }


        DataSet CreateDataset_Table()
        {
            DataSet data = new DataSet();

            DataTable parentTable = new DataTable("Customers");
            data.Tables.Add(parentTable);

            parentTable.Columns.Add("string", typeof(string));

            for (int customerID = 1; customerID <= 2; customerID++)
                data.Tables["Customers"].Rows.Add(new object[] { "test\ntest" });
            for (int customerID = 1; customerID <= 2; customerID++)
                data.Tables["Customers"].Rows.Add(new object[] { "test\ntest\ntest" });
            for (int customerID = 1; customerID <= 2; customerID++)
                data.Tables["Customers"].Rows.Add(new object[] { "test" });
            return data;
        }
    }
}
