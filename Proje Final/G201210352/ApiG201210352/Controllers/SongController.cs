using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ApiG201210352.Models;

namespace ApiG201210352.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public SongController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                            select Id,SongName, Price,Quantity,PublishYear,ReleaseDate,Description,CreateDate,Stock,Active from
                            dbo.Song
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Song song)
        {
            string query = @"
                           insert into dbo.Song
                           (SongName, Price,Quantity,PublishYear,ReleaseDate,Description,CreateDate,Stock,Active)
                    values (@SongName,@Price,@Quantity,@PublishYear,@ReleaseDate,@Description,@CreateDate,@Stock,@Active)
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@SongName", song.SongName);
                    myCommand.Parameters.AddWithValue("@Price", song.Price);
                    myCommand.Parameters.AddWithValue("@Quantity", song.Quantity);
                    myCommand.Parameters.AddWithValue("@PublishYear", song.PublishYear);
                    myCommand.Parameters.AddWithValue("@ReleaseDate", song.ReleaseDate);
                    myCommand.Parameters.AddWithValue("@Description", song.Description);
                    myCommand.Parameters.AddWithValue("@CreateDate", song.CreateDate);
                    myCommand.Parameters.AddWithValue("@Stock", song.Stock);
                    myCommand.Parameters.AddWithValue("@Active", song.Active);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Added Successfully");
        }

        [HttpPut]
        public JsonResult Put(Song song)
        {
            string query = @"
                           update dbo.Song
                           set SongName= @SongName,
                            Price=@Price,
                            Quantity=@Quantity,
                            PublishYear=@PublishYear,
                            ReleaseDate=@ReleaseDate,
                            Description=@Description,
                            CreateDate=@CreateDate,
                            Stock=@Stock,
                            Active=@Active    
                            where Id=@Id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", song.Id);
                    myCommand.Parameters.AddWithValue("@SongName", song.SongName);
                    myCommand.Parameters.AddWithValue("@Price", song.Price);
                    myCommand.Parameters.AddWithValue("@Quantity", song.Quantity);
                    myCommand.Parameters.AddWithValue("@PublishYear", song.PublishYear);
                    myCommand.Parameters.AddWithValue("@ReleaseDate", song.ReleaseDate);
                    myCommand.Parameters.AddWithValue("@Description", song.Description);
                    myCommand.Parameters.AddWithValue("@CreateDate", song.CreateDate);
                    myCommand.Parameters.AddWithValue("@Stock", song.Stock);
                    myCommand.Parameters.AddWithValue("@Active", song.Active);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Updated Successfully");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                           delete from dbo.Song
                            where Id=@Id
                            ";

            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("EmployeeAppCon");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@Id", id);

                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Deleted Successfully");
        }
    }
}
