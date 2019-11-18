using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class TarefaProcessor
    {
        public static int CreateTarefa(string nome, string descricao, DateTime data)
        {
            TarefaModel dataPrazo = new TarefaModel
            {
                Nome = nome,
                Descricao = descricao,
                Data = data
            };

            string sql = @"insert into dbo.Tarefa (Nome, Descricao, Data) 
                            values (@Nome, @Descricao, @Data);";
            return SqlDataAccess.SaveData(sql, dataPrazo);
        }

        public static List<TarefaModel> LoadTarefas()
        {
            string sql = @"select Id, Nome, Descricao, Data from dbo.Tarefa;";
            return SqlDataAccess.LoadData<TarefaModel>(sql);
        }
    }
}
