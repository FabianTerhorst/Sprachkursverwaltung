﻿using System;
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

        public void update(String sql, List<OleDbParameter> parameters)
        {
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            for (int i = 0; i < parameters.Count; i++)
            {
                cmd.Parameters.Add(parameters[i]);
            }
            cmd.ExecuteNonQuery();
            //connection.Close();
        }

        public int insert(String sql, List<OleDbParameter> parameters)
        {
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;
            for(int i = 0;i < parameters.Count;i++){
                cmd.Parameters.Add(parameters[i]);
            }
            //cmd.ExecuteNonQuery();
            int? modified = (int?)cmd.ExecuteScalar();
            //connection.Close();
            if (modified == null)
                return 0;
            return (int)modified;
        }

        public void load()
        {
            DataTable memberTable = query("SELECT * FROM member");
            foreach (DataRow row in memberTable.Rows)
            {
                Member member = new Member();
                member.id = (int)row[0];
                member.name = row[1].ToString();
                members.Add(member);
            }

            DataTable courseTable = query("SELECT * FROM course");
            foreach (DataRow row in courseTable.Rows)
            {
                Course course = new Course();
                course.id = (int)row[0];
                course.name = row[1].ToString();
                courses.Add(course);
            }

            DataTable languageTable = query("SELECT * FROM courselanguage");
            foreach (DataRow row in languageTable.Rows)
            {
                Language language = new Language();
                language.id = (int)row[0];
                language.name = row[1].ToString();
                languages.Add(language);
            }
        }

        public void addCourse(int name)
        {
            Course course = new Course();
            course.name = name.ToString();
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

        public int saveCourse(int name)
        {
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("@Courselanguage", name));
            return insert("INSERT INTO course (Courselanguage) VALUES (@Courselanguage)", parameters);
        }

        public int saveMember(String name)
        {
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("@Forename", name));
            return insert("INSERT INTO member (Forename) VALUES (@Forename)", parameters);
        }

        public void editMember(int id, String name)
        {
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("@Forename", name));
            parameters.Add(new OleDbParameter("@ID", id));
            update("UPDATE member SET Forename = @Forename WHERE ID = @ID", parameters);
            foreach (Member member in members)
            {
                if (member.id == id)
                {
                    member.name = name;
                }
            }
        }

        public void editCourse(int id, int language)
        {
            List<OleDbParameter> parameters = new List<OleDbParameter>();
            parameters.Add(new OleDbParameter("@CourseLanguage", language));
            parameters.Add(new OleDbParameter("@ID", id));
            update("UPDATE course SET CourseLanguage = @CourseLanguage WHERE ID = @ID", parameters);
            foreach (Course course in courses)
            {
                if (course.id == id)
                {
                    course.name = language.ToString();
                }
            }
        }

    }
}
