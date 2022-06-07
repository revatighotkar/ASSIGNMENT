using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class EnrollApp : IEnrollApp
    {
        SqlConnection con = new SqlConnection("Data Source= POOLW42SLPC6862\\SQLEXPRESS;Database=StudentDB;User ID =sa;Password=Temp1234");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public int register(Student student)
        {
            try
            {

                cmd = new SqlCommand("insert into Student values(@Id, @Name,@Dob)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@Name", student.Name);
                cmd.Parameters.AddWithValue("@Dob", student.Dob);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    return res;
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return 0;

        }

        public int UpdateStudent(int id, string name, string dob)
        {
            try
            {


                cmd = new SqlCommand("update Student set Name=@name,Dob=@dob where Id=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    return res;
                }
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return 0;
        }

        public int deleteStudent(int id)
        {
            try
            {

                cmd = new SqlCommand("delete Student where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return res;
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return 0;
        }

        public Student getStudent(int id)
        {
            try
            {

                cmd = new SqlCommand("select * from  Student  where Id=@Id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Student Id : " + reader[0] + " " + "Student Name : " + reader[1] + " " + "Student DOB : " + reader[2]);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public List<Student> getStudents()
        {
            List<Student> list = new List<Student>();
            try
            {

                cmd = new SqlCommand("select * from  Student ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Console.WriteLine("Student Id : " + reader[0] + " " + "Student Name : " + reader[1] + " " + "Student DOB : " + reader[2]);
                    Student s = new Student(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString());
                    list.Add(s);
                }
                
                con.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return list;
        } 


        public int addCourse(Course course) {
            try
            {

                cmd = new SqlCommand("insert into Course values(@Id, @Name,@Duration, @Fees)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id", course.Id);
                cmd.Parameters.AddWithValue("@Name", course.Name);
                cmd.Parameters.AddWithValue("@Duration", course.Duration);
                cmd.Parameters.AddWithValue("@Fees", course.Fees);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    return res;
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return 0;

        }

         public List<Course> getCourses() {
           List<Course> list = new List<Course>();
            try
            {

                cmd = new SqlCommand("select * from  Course ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course course = new Course(Convert.ToInt32(reader[0]), reader[1].ToString(), Convert.ToInt32(reader[2]),Convert.ToInt32(reader[3]));
                    list.Add(course);
                }

                con.Close();
                return list;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return list;

        }

        public int deleteCourse(int id)
        {
            try
            {
                cmd = new SqlCommand("delete Course where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return res;
                con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
            return 0;
        }
    }

}
   