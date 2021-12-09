namespace CsharpFirstProject
{
    internal interface IDataAccess
    {
        string LoadConnectionString(string name);
        void LoadData(string sql);
        void SaveData(string sql);
    }
}