using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class SubCategoryDetailsService
    {
        SubCategoryDetailsEntry subCategoryDetailsEntry = new SubCategoryDetailsEntry();

        public DataTable SelectSubCategoriesRelatedToMainCategory(SubCategoryDetails subCategoryDetails)
        {
            try
            {
                return subCategoryDetailsEntry.SelectSubCategoriesRelatedToMainCategory(subCategoryDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable Select(SubCategoryDetails subCategoryDetails)
        {
            try
            {
                return subCategoryDetailsEntry.Select(subCategoryDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Insert(SubCategoryDetails subCategoryDetails)
        {
            try
            {
                subCategoryDetailsEntry.Insert(subCategoryDetails,CommonParameterNames.Operations.Insert);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(SubCategoryDetails subCategoryDetails)
        {
            try
            {
                subCategoryDetailsEntry.Insert(subCategoryDetails, CommonParameterNames.Operations.Update);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(SubCategoryDetails subCategoryDetails)
        {
            try
            {
                subCategoryDetailsEntry.Delete(subCategoryDetails);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}