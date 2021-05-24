using Models.SqlFiles;

namespace Controllers.SqlFilesControls
{
    public class SqlUtilsController
    {
        private SqlUtiles sql = new SqlUtiles();

        public string FillComboBox()
        {
            return sql.FillComboBox();
        }
    }
}
