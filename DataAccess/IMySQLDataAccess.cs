namespace DataAccess
{
    public interface IMySQLDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
        Task SaveData<T>(string sql, T parameters, string connectionString);
        Task<int> CreateRecordReturnID<T>(string sql, T parameters, string connectionString);
    }
}