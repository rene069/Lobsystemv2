﻿using Lobsystem.Shared.Models;

namespace Lobsystem.Client.IAPICallers
{
    public interface IPostCaller
    {
        void AddPostFromList(List<Post> list, int id);

        List<Post> GetAllPostByEventID(int id);

        List<Post> GetAllPosts();

        void DeletePost(int ID);

        void SortPosts(List<Post> list, int id);

        void SortDeletedPosts(List<Post> list);

        bool TypeExists(int ID);
        bool TypeExists(string TypeName);
    }
}