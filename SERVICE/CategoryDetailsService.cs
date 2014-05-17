using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN;

namespace SERVICE
{
    public class CategoryDetailsService
    {
        CategoryDetailsEntry categoryDetailsEntry = new CategoryDetailsEntry();

        public DataTable SelectCategoriesFornavigationBar()
        {
            try
            {
                return categoryDetailsEntry.SelectCategoriesFornavigationBar();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable Select(CategoryDetails categoryDetails)
        {
            try
            {
                return categoryDetailsEntry.Select(categoryDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Insert(CategoryDetails categoryDetails)
        {
            try
            {
                categoryDetailsEntry.Insert(categoryDetails,CommonParameterNames.Operations.Insert);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(CategoryDetails categoryDetails)
        {
            try
            {
                categoryDetailsEntry.Insert(categoryDetails, CommonParameterNames.Operations.Update);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(CategoryDetails categoryDetails)
        {
            try
            {
                categoryDetailsEntry.Delete(categoryDetails);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}