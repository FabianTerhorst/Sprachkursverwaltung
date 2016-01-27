using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprachkursverwaltung
{
    class SprachkursApplication
    {
        public static SprachkursApplication application;

        private String OleDBProvider = "Microsoft.JET.OLEDB.4.0;";
        private String OleDBDataSource = "Sprachkursverwaltung.mdb;";

        OleDbConnection connection;

        public List<Member> members;

        public List<Course> courses;

        public List<Language> languages;

        public static SprachkursApplication Instance
        {
            get
            {
                if (application == null)
                {
                    application = new SprachkursApplication();
                }
                return application;
            }
        }

        public SprachkursApplication()
        {
            members = new List<Member>();

            courses = new List<Course>();

            languages = new List<Language>();

            openConnection();

            load();
        }

        public void openConnection()
        {
            connection = new OleDbConnection("Provider=" + OleDBProvider + "Data Source=" + OleDBDataSource);
            connection.Open();
        }

        public DataTable query(String sql)
        {
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            OleDbDataReader reader = cmd.ExecuteReader(/*CommandBehavior.CloseConnection*/);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public int insert(String sql, List<OleDbParameter> parameters)
        {
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            for(int i = 0;i < parameters.Count;i++){
                cmd.Parameters.Add(parameters[i]);
            }
            //cmd.ExecuteNonQuery();
            int modified = (int)cmd.ExecuteScalar();
            connection.Close();
            return modified;
        }

        public void load()
        {
            DataTable memberTable = query("SELECT * FROM member");
            foreach (DataRow row in memberTable.Rows)
            {
                Member member = new Member();
                member.name = row[0].ToString();
                members.Add(member);
            }

            DataTable courseTable = query("SELECT * FROM course");
            foreach (DataRow row in courseTable.Rows)
            {
                Course course = new Course();
                course.name = row[0].ToString();
                courses.Add(course);
            }

            DataTable languageTable = query("SELECT * FROM language");
            foreach (DataRow row in languageTable.Rows)
            {
                Language language = new Language();
                language.name = row[0].ToString();
                languages.Add(language);
            }
        }

        public void addCourse(String name)
        {
            Course course = new Course();
            course.name = name;
            course.id = saveCourse(name);
            courses.Add(course);
        }

        public void addMember(String name)
        {
            Member member = new Member();
            member.name = name;
            member.id = saveMember(name);
            members.Add(member);
        }

        public int saveCourse(String name)
        {
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("@Forename", name));
            return insert("insert (Forename) into course values (@Forename)", parameters);
        }

        public int saveMember(String name)
        {
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("@Forename", name));
            return insert("insert (Forename) into member values (@Forename)", parameters);
        }

    }
}
