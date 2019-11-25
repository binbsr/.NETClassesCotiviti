using System;
using System.Collections.Generic;
public class Faculty {

    public int Id { get; set; } //instance member: as can be used by the instance of this class
    public string FacultyName { get; set; }
    public string HOD { get; set; }
   
   
   
    public static List<Faculty> FetchFaculties() {
        List<Faculty> faculties = new List<Faculty> ();
        faculties.Add (new Faculty { Id = 1, FacultyName = "CS", HOD="HOD1"});
        faculties.Add (new Faculty { Id = 2, FacultyName = "CE", HOD="HOD2"});
        faculties.Add (new Faculty { Id = 3, FacultyName = "ME", HOD="HOD3"});
        faculties.Add (new Faculty { Id = 4, FacultyName = "BioTech", HOD="HOD4"});        
        return faculties;
    }}
