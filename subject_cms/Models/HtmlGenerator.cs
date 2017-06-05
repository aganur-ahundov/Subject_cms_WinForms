using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HtmlAgilityPack;
using subject_cms.Utilites;


namespace subject_cms.Models
{
    public class HtmlGenerator
    {
        private HtmlDocument index = new HtmlDocument();
        private Subject subject;
        private string root;
        private string htmlFilePath;
        private string cssFilePath;


        public HtmlGenerator( string _root, Subject _subject, AdditionalsConfigurations _config )
        {
            subject = _subject;
            htmlFilePath = _root + @"\index.html";
            cssFilePath = _root + @"\site.css";
            root = _root;

            string path = AppDomain.CurrentDomain.BaseDirectory;
            //HERE NEED TO CHANGE STATIC FILE PATH
            File.Copy ( @"D:\VS17 Projects\subject_cms\subject_cms\subject_cms\html_templates\html_empty.html", htmlFilePath );


            index.Load( htmlFilePath );
            fillMainInfo();

            HtmlNode semestersContainer = index.GetElementbyId( HtmlElementID.SEMESTERS_CONTAINER_ID );


            foreach ( Semester current in subject.Semesters )
            {
                semestersContainer.ChildNodes.Add ( createSemester ( current ) );
            }

            set_settings( _config );
            
            
            index.Save( htmlFilePath );
        }


        private void fillMainInfo()
        {
            index.GetElementbyId ( HtmlElementID.PAGE_TITLE_ID ).InnerHtml = "Subject_cms";

            index.GetElementbyId ( HtmlElementID.SUBJECT_TITLE_ID ).InnerHtml = subject.Title;
            index.GetElementbyId ( HtmlElementID.TEACHER_NAME_ID ).InnerHtml = subject.TeacherName;
            index.GetElementbyId ( HtmlElementID.SEMESTERS_AMOUNT_ID ).InnerHtml = string.Format( "Semesters Amount: {0}", subject.Semesters.Count );
            index.GetElementbyId ( HtmlElementID.TOTAL_HOURS_IN_SUBJECT_ID ).InnerHtml = string.Format( "Total hours: {0}", subject.GetTotalHours() );
        }


        //Creates div with semester's info
        private HtmlNode createSemester( Semester _semester )
        {
            HtmlNode semester = createNodeWithClass( "div", HtmlElementID.SEMESTER_ID );

            HtmlNode semesterHead = createNodeWithClass ( "h1", HtmlElementID.SEMESTER_TITLE_ID );
            semesterHead.InnerHtml = _semester.Title;

            HtmlNode semesterType = createNodeWithClass ( "h4", HtmlElementID.SEMESTER_TYPE_ID ); 
            semesterType.InnerHtml = _semester.Type.ToString();

            HtmlNode horizontalLine = index.CreateElement ( "hr" );

            HtmlNode lectures = createLesson ( _semester.Lectures );
            HtmlNode practice = createLesson ( _semester.Practice );
            HtmlNode laboratory = createLesson ( _semester.Laboratory );

            semester.ChildNodes.Add ( semesterHead );
            semester.ChildNodes.Add ( semesterType );
            semester.ChildNodes.Add ( horizontalLine );
            semester.ChildNodes.Add ( lectures );
            semester.ChildNodes.Add ( practice );
            semester.ChildNodes.Add( laboratory );

            return semester;
        } 


        private HtmlNode createLesson( Lesson _lesson )
        {
            if ( _lesson.Hours == 0 )
                return index.CreateElement( "span" );

            HtmlNode lesson = createNodeWithClass ( "div", HtmlElementID.LESSON_ID );
            HtmlNode lessonType = createNodeWithClass ( "h2", HtmlElementID.LESSON_TYPE_ID );
            lessonType.InnerHtml = _lesson.Type.ToString();

            HtmlNode lessonHours = createNodeWithClass ( "h4", HtmlElementID.LESSON_HOURS_AMOUNT_ID );
            lessonHours.InnerHtml = "Hours: " + _lesson.Hours.ToString();

            HtmlNode lessonLinksList = createNodeWithClass ( "ul", HtmlElementID.LESSON_LIST_ID );

            foreach ( FileContainer current in _lesson.Files )
            {
                if ( !current.IsAvailable )
                    continue;

                HtmlNode li = index.CreateElement ( "li" );
                HtmlNode link = index.CreateElement ( "a" );
                link.SetAttributeValue ( "href", current.file.FullName );
                link.SetAttributeValue ( "title", current.Description );
                link.SetAttributeValue ( "download", null );

                link.InnerHtml = current.Title;
                li.ChildNodes.Add ( link );
                lessonLinksList.ChildNodes.Add ( li );
            }

            lesson.ChildNodes.Add ( lessonType );
            lesson.ChildNodes.Add ( lessonHours );
            lesson.ChildNodes.Add ( lessonLinksList );

            return lesson;
        }


        private HtmlNode createNodeWithClass ( string _name, string _class )
        {
            HtmlNode node = index.CreateElement ( _name );
            node.SetAttributeValue( "class", _class );

            return node;
        }

        private void set_settings ( AdditionalsConfigurations _config )
        {
            //CSS FILE BY DEFAULT
            if ( string.IsNullOrEmpty( _config.CSSFilePath ) )
            {
                File.Copy( @"D:\VS17 Projects\subject_cms\subject_cms\subject_cms\html_templates\site.css", cssFilePath );
                File.Copy( @"D:\VS17 Projects\subject_cms\subject_cms\subject_cms\html_templates\content\bg5.png", root + @"\bg5.png" );
                File.Copy( @"D:\VS17 Projects\subject_cms\subject_cms\subject_cms\html_templates\content\header_background.png", root + @"\header_background.png" );

                addCSSLink( cssFilePath );
            }
            else
            {
                addCSSLink ( _config.CSSFilePath );
            }

            if ( _config.ScriptFilesPaths != null )
            {
                foreach ( string path in _config.ScriptFilesPaths )
                {
                    addScript( path );
                }
            }

            if ( _config.BackgroundColor != null )
            {
                HtmlNode body = index.GetElementbyId( "body" );
                    body.SetAttributeValue( "style"
                      , string.Format( "background: rgb({0},{1},{2})"
                      , _config.BackgroundColor?.R
                      , _config.BackgroundColor?.G
                      , _config.BackgroundColor?.B ));
            }

            if ( _config.HeaderColor != null )
            {
                HtmlNode body = index.GetElementbyId( "main-info" );
                body.SetAttributeValue( "style"
                  , string.Format( "background: rgb({0},{1},{2})"
                  , _config.HeaderColor?.R
                  , _config.HeaderColor?.G
                  , _config.HeaderColor?.B ));
            }
        }


        private void addCSSLink ( string _cssFilePath )
        {
            HtmlNode links = index.GetElementbyId( HtmlElementID.LINKS_ID );
            HtmlNode newLink = index.CreateElement( "link" );
            newLink.SetAttributeValue( "rel", "stylesheet" );
            newLink.SetAttributeValue( "type", "text/css" );
            newLink.SetAttributeValue( "href", _cssFilePath );
            links.ChildNodes.Add( newLink );
        }

        private void addScript ( string _scriptFilePath )
        {
            HtmlNode links = index.GetElementbyId( HtmlElementID.LINKS_ID );
            HtmlNode newLink = index.CreateElement( "script" );
            newLink.SetAttributeValue( "type", "text/javascript" );
            newLink.SetAttributeValue( "src", _scriptFilePath );
            links.ChildNodes.Add( newLink );
        }

    }
}
