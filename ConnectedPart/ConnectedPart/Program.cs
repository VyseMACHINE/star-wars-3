using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace ConnectedPart
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                string result = client.DownloadString("https://swapi.co/api/people/1/");
                People person = JsonConvert.DeserializeObject<People>(result);
               

                string result2 = client.DownloadString("https://swapi.co/api/planets/3/");
                Planets planet = JsonConvert.DeserializeObject<Planets>(result2);
                
                string result3 = client.DownloadString("https://swapi.co/api/starships/9/");
                Starships starship = JsonConvert.DeserializeObject<Starships>(result3);

                using (var connection = new SqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.
                        ConnectionStrings["StarWarsConnectionString"].
                        ConnectionString;
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = $"insert into People values " +
                        $"('{person.Name}', '{person.Height}'" +
                        $"'{person.Mass}', '{person.HairColor}'" +
                        $"'{person.SkinColor}', '{person.EyeColor}'" +
                        $"'{person.BirthYear}', '{person.Gender}'" +
                        $"'{person.Homeworld}','{person.Films}')" +
                        $"'{person.Species}','{person.Vehicles}')" +
                        $"'{person.Starships}','{person.Films}')" +
                        $"'{person.Created}','{person.Edited}')" +
                        $"'{person.Url}')";


                    command.CommandText = $"insert into Planets values " +
                        $"('{planet.Name}', '{planet.RotationPeriod}'" +
                        $"'{planet.Diameter}', '{planet.Climate}'" +
                        $"'{planet.Gravity}', '{planet.Terrain}'" +
                        $"'{planet.SurfaceWater}', '{planet.Population}'" +
                        $"'{planet.Residents}','{planet.Films}')" +
                        $"'{planet.Created}','{planet.Edited}')" +
                        $"'{planet.Url}')";


                    command.CommandText = $"insert into Starships values " +
                        $"('{starship.Name}', '{starship.Model}'" +
                        $"'{starship.Manufacturer}', '{starship.CostInCredits}'" +
                        $"'{starship.Length}', '{starship.MaxAtmospheringSpeed}'" +
                        $"'{starship.Crew}', '{starship.Passengers}'" +
                        $"'{starship.CargoCapacity}', '{starship.Consumables}'" +
                        $"'{starship.HyperdriveRating}', '{starship.MGLT}'" +
                        $"'{starship.StarshipClass}', '{starship.Pilots}')" +
                        $"'{planet.Films}idents','{planet.Created}')" +
                        $"'{planet.Edited}','{planet.Url}')";
                        

                    command.ExecuteNonQuery();

                    SqlCommand selectCommand = new SqlCommand();
                    selectCommand.Connection = connection;
                    selectCommand.CommandText = "select * from People";
                    selectCommand.CommandText = "select * from Planets";
                    selectCommand.CommandText = "select * from Starships";
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while(reader.NextResult())
                    {
                        People gotPerson = new People
                        {
                            Name = reader["Name"].ToString(),
                            Height = reader["Height"].ToString(),
                            Mass = reader["Mass"].ToString(),
                            HairColor = reader["HairColor"].ToString(),
                            SkinColor = reader["SkinColor"].ToString(),
                            EyeColor = reader["EyeColor"].ToString(),
                            BirthYear = reader["BirthYear"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Homeworld = reader["Homeworld"].ToString()                        
                        };

                        Planets gotPlanet = new Planets
                        {
                            Name = reader["Name"].ToString(),
                            RotationPeriod = reader["RotationPeriod"].ToString(),
                            Diameter = reader["Diameter"].ToString(),
                            Climate = reader["Climate"].ToString(),
                            Gravity = reader["Gravity"].ToString(),
                            Terrain = reader["Terrain"].ToString(),
                            SurfaceWater = reader["SurfaceWater"].ToString(),
                            Population = reader["Population"].ToString(),
                           
                        };

                        Starships gotStarships = new Starships
                        {
                            Name = reader["Name"].ToString(),
                            Model = reader["Model"].ToString(),
                            Manufacturer = reader["Manufacturer"].ToString(),
                            CostInCredits = reader["CostInCredits"].ToString(),
                            Length = reader["Length"].ToString(),
                            MaxAtmospheringSpeed = reader["MaxAtmospheringSpeed"].ToString(),
                            Crew = reader["Crew"].ToString(),
                            Passengers = reader["Passengers"].ToString(),
                            CargoCapacity = reader["CargoCapacity"].ToString(),
                            Consumables = reader["Consumables"].ToString(),
                            HyperdriveRating = reader["HyperdriveRating"].ToString(),
                            MGLT = reader["MGLT"].ToString(),
                            StarshipClass = reader["StarshipClass"].ToString(),                         
                        };
                    }                  
                }
            }
        }
    }
}
