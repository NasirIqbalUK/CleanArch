﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _context;
        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IQueryable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
