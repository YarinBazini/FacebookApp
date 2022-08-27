using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace FacebookAppLogic
{
    public class YearSummery
    {
        private readonly int r_Year;
        private readonly int r_NumOfPosts;
        private readonly int r_NumOfLikes;
        private readonly int r_NumOfComments;
        private readonly Post r_TopCommentedPost;
        private readonly Post r_WorstCommentedPost;
        private readonly Post r_TopLikedPost;
        private readonly Post r_WorstLikedPost;
        private readonly Random r_random = new Random();

        public YearSummery(List<Post> i_Posts, int i_Year)
        {
            int maxComments = 0, minComments = 0, topLikes = 0, minLikes = 0, currentCommentCount, currentLikesCount, totalCommentsCount = 0, totalLikesCount = 0;
            bool isFirstPost = true;

            foreach (Post post in i_Posts)
            {
                currentCommentCount = getAmountOfComments(post);
                currentLikesCount = getAmountOfLikes(post);
                if (isFirstPost == true)
                {
                    isFirstPost = false;
                    initFirstIterationParams(out maxComments, out minComments, out topLikes, out minLikes, currentCommentCount, currentLikesCount);
                }

                if (maxComments <= currentCommentCount)
                {
                    maxComments = currentCommentCount;
                    r_TopCommentedPost = post; 
                }
                else if (minComments >= currentCommentCount)
                {
                    minComments = currentCommentCount;
                    r_WorstCommentedPost = post;
                }

                if (minLikes >= currentLikesCount)
                {
                    r_WorstLikedPost = post;
                    minLikes = currentLikesCount;
                }
                else if (topLikes <= currentLikesCount)
                {
                    topLikes = currentLikesCount;
                    r_TopLikedPost = post;
                }

                totalCommentsCount += currentCommentCount;
                totalLikesCount += currentLikesCount;
            }

            r_NumOfComments = totalCommentsCount;
            r_NumOfLikes = totalLikesCount;
            r_NumOfPosts = i_Posts.Count;
            r_Year = i_Year;
        }

        public int Year
        {
            get
            {
                return r_Year;
            }
        }

        public int NumOfLikes
        {
            get
            {
                return r_NumOfLikes;
            }
        }

        public int NumOfComments
        {
            get
            {
                return r_NumOfComments;
            }
        }

        public Post TopLikedPost
        {
            get
            {
                return r_TopLikedPost;
            }
        }

        public Post TopCommentedPost
        {
            get
            {
                return r_TopCommentedPost;
            }
        }

        public Post WorstCommenedtPost
        {
            get
            {
                return r_WorstCommentedPost;
            }
        }

        public Post WorstLikedPost
        {
            get
            {
                return r_WorstLikedPost;
            }
        }

        private int getAmountOfLikes(Post i_Post)
        {
            int likesCount = 0;

            try
            {
                likesCount = i_Post.LikedBy.Count;
            }
            catch (Exception exception)
            {
                likesCount = r_random.Next(0, 100);
            }

            return likesCount;
        }

        private int getAmountOfComments(Post i_Post)
        {
            int commentsCount = 0;

            try
            {
                commentsCount = i_Post.Comments.Count;
            }
            catch (Exception exception)
            {
                commentsCount = r_random.Next(0, 100);
            }

            return commentsCount;
        }

        private void initFirstIterationParams(out int o_MaxComments, out int o_MinComments, out int o_TopLikes, out int o_MinLikes, int i_CurrentCommentCount, int i_CurrentLikesCount)
        {
            o_MaxComments = i_CurrentCommentCount;
            o_MinComments = i_CurrentCommentCount;
            o_TopLikes = i_CurrentLikesCount;
            o_MinLikes = i_CurrentLikesCount;
        }
    }
}
