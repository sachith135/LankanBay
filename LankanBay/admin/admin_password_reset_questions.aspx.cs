using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using System.Data;
using Telerik.Web.UI;

namespace LankanBay.admin
{
    public partial class admin_password_reset_questions : System.Web.UI.Page
    {
        PasswordResetQuestionsService passwordResetQuestionsService = new PasswordResetQuestionsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (true)
            {
                FillGrid();
            }
        }

        private void FillGrid()
        {
            dgPasswordResetQuestions.DataSource = passwordResetQuestionsService.Select();
            dgPasswordResetQuestions.DataBind();
        }


        protected void dgPasswordResetQuestions_ItemCommand(object source, GridCommandEventArgs e)
        {

        }     

        protected void dgPasswordResetQuestions_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            dgPasswordResetQuestions.DataSource = passwordResetQuestionsService.Select();
        }

        protected void dgPasswordResetQuestions_PageIndexChanged(object source, GridPageChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgPasswordResetQuestions_PageSizeChanged(object source, GridPageSizeChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgPasswordResetQuestions_SortCommand(object source, GridSortCommandEventArgs e)
        {
            FillGrid();
        }
    }
}