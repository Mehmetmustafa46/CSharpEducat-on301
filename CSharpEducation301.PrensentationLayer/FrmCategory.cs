﻿using CSharpEducation.BusinessLayer.Concrete;
using CSharpEducatıon301.EntityLayer;
using CSharpEducation301.DataAccessLayer.EntityFramework;  // EfCategoryDal için
using CSharpEducation301.DataAccessLayer.Abstract;  // ICategoryDal için

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEducatıon301.EntityLayer.Concrete;

namespace CSharpEducation301.PrensentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;


        public FrmCategory()
        {
            _categoryService = new CategoryManager(new CSharpEducation301.DataAccessLayer.EntityFramework.EfCategoryDal());

            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("ekleme başarılı");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           int id= int.Parse(txtCategoryId.Text);
            var deletedValues=_categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme  bşarılı");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtCategoryId.Text);
            var values=_categoryService.TGetById(id);
            dataGridView1 .DataSource = values;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            int updatedId=int.Parse(txtCategoryId.Text);
            var updatedValue=_categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
        }
    }
}
