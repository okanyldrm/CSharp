﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void Form1_Load(object sender, EventArgs e)
        {

            dgwProducts.DataSource = _productDal.GetAll();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)


            });
            //load Product
            dgwProducts.DataSource = _productDal.GetAll();
            MessageBox.Show("Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            dgwProducts.DataSource = _productDal.GetAll();
            MessageBox.Show("Updated!");
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value)

            });
            dgwProducts.DataSource = _productDal.GetAll();
            MessageBox.Show("Deleted!");
        }

        private void SearchProduct(string key)
        {
            //koleksiyona filtreleme yapıyoruz
            //var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            var result = _productDal.GetByName(key);
            dgwProducts.DataSource = result;
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(tbxSearch.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productDal.GetById(1);
        }
    }
}
