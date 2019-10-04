﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikuReader.Core
{
    /// <summary>
    /// Representation of a Chapter (of a Title)
    /// </summary>
    public class Chapter
    {
        private readonly DirectoryInfo chapterRoot;
        private readonly List<Page> pages;
        private readonly string chapterID;

        /// <summary>
        /// Create a new Chapter
        /// </summary>
        /// <param name="chapterRoot">Root directory for this chapter</param>
        public Chapter(DirectoryInfo chapterRoot)
        {
            this.pages = new List<Page>();
            this.chapterRoot = chapterRoot;
            this.chapterID = chapterRoot.Name;
            foreach (FileInfo fi in FileHelper.GetFiles(chapterRoot))
            {
                pages.Add(new Page(fi.FullName));
            }
        }

        /// <summary>
        /// Get the ID of the chapter
        /// </summary>
        /// <returns>The chapter ID</returns>
        public string GetID()
        {
            return chapterID;
        }

        /// <summary>
        /// Get the root directory for this chapter
        /// </summary>
        /// <returns>DirectoryInfo object for the chapter root</returns>
        public DirectoryInfo GetChapterRoot()
        {
            return chapterRoot;
        }

        /// <summary>
        /// Get the list of pages in this chapter
        /// </summary>
        /// <returns>ArrayList of Page objects for this chapter</returns>
        public List<Page> GetPages()
        {
            return pages;
        }

        public Page GetPage(int index)
        {
            return pages[index];
        }
    }
}
