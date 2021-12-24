using BlogMvcApp.Src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMvcApp.Src.Services
{
    public interface IPostService
    {
        /// <summary>
        /// Veritabanında kayıtlı olan bütün postları getirir.
        /// </summary>
        /// <returns>
        /// Post listesi döndürür.
        /// </returns>
        List<Post> GetPosts();

        /// <summary>
        /// Post Id'ye göre veritabanından ilgili Post çekilir ve döndürülür
        /// </summary>
        /// <param name="Id">Getirilecek Postun Id'si buraya parametre olarak yollanır.</param>
        /// <returns>Verilen Id'ye sahip olan Post'u döndürür.</returns>
        Post GetPostById(string Id);

        /// <summary>
        /// Verilen categoryId'ye göre veritabanından o kategorinin tüm postlarını liste halinde döndürür
        /// </summary>
        /// <param name="categoryId">İstenilen postların categoryId'si gönderilir.</param>
        /// <returns>Verilen kategorinin Tüm Postları döndürülür.</returns>
        List<Post> GetPostsByCategoryId(string categoryId);

        /// <summary>
        /// Verilen TagId'ye göre O tag'e sahip olan bütün Postları döndürür.
        /// </summary>
        /// <param name="tagId">Parametre olarak tagId alır. </param>
        /// <returns>
        /// Verilen tagId 'ye sahip olan bütün Postları döndürür.
        /// </returns>
        List<Post> GetPostsByTagId(string tagId);
        List<Post> GetRecentPosts();


        void AddPost(Post post, string Tags);
       
    }
}

