namespace TaskEF
{
    public partial class Form1 : Form
    {
        public static int cur_id;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (NihatContext db = new NihatContext())
            {
                dataGridView1.DataSource = db.nihatProducts.ToList();
            }
        }
        private void ClearTbs(TextBox[] tbs)
        {
            foreach (TextBox t in tbs)
            {
                t.Text = string.Empty;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NihatProduct product = new NihatProduct();
            product.Name = nametextBox.Text;
            product.Description = desctextBox.Text;
            product.Category = categorytextBox.Text;

            using (NihatContext db = new NihatContext())
            {
                db.nihatProducts.Add(product);
                db.SaveChanges();
                ClearTbs(new TextBox[] { nametextBox, desctextBox, categorytextBox });
                LoadData();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index > -1)
            {
                using (NihatContext db = new NihatContext())
                {
                    cur_id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    NihatProduct p = db.nihatProducts.Find(cur_id);
                    nametextBox.Text = p.Name;
                    desctextBox.Text = p.Description;
                    categorytextBox.Text = p.Category;
                }

            }
            else cur_id = -1;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (cur_id > -1)
            {
                using (NihatContext db = new NihatContext())
                {
                    NihatProduct p = db.nihatProducts.Find(cur_id);
                    p.Description = desctextBox.Text;
                    p.Category = categorytextBox.Text;
                    p.Name = nametextBox.Text;
                    db.nihatProducts.Update(p);
                    db.SaveChanges();
                    LoadData();
                    ClearTbs(new TextBox[] { nametextBox, desctextBox, categorytextBox });
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (cur_id > -1)
            {
                using(NihatContext db=new NihatContext())
                {
                    NihatProduct p = db.nihatProducts.Find(cur_id);
                    db.nihatProducts.Remove(p);
                    db.SaveChanges();
                    LoadData();
                    ClearTbs(new TextBox[] { nametextBox, desctextBox, categorytextBox });
                }
            }
        }
    }
}
