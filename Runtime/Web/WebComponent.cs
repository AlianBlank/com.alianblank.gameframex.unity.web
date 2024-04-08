﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.Web.Runtime
{
    /// <summary>
    /// Web 请求组件。
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Web")]
    public sealed class WebComponent : GameFrameworkComponent
    {
        private IWebManager m_WebManager;

        /// <summary>
        /// 游戏框架组件初始化。
        /// </summary>
        protected override void Awake()
        {
            base.Awake();
            new WebManager();
            m_WebManager = GameFrameworkEntry.GetModule<IWebManager>();
            if (m_WebManager == null)
            {
                Log.Fatal("Web manager is invalid.");
                return;
            }
        }

        /// <summary>
        /// 发送Get 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public Task<string> GetToString(string url)
        {
            return m_WebManager.GetToString(url);
        }

        /// <summary>
        /// 发送Get 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryString">请求参数</param>
        /// <returns></returns>
        public Task<string> GetToString(string url, Dictionary<string, string> queryString)
        {
            return m_WebManager.GetToString(url, queryString);
        }

        /// <summary>
        /// 发送Get 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryString">请求参数</param>
        /// <param name="header">请求头</param>
        /// <returns></returns>
        public Task<string> GetToString(string url, Dictionary<string, string> queryString, Dictionary<string, string> header)
        {
            return m_WebManager.GetToString(url, queryString, header);
        }


        /// <summary>
        /// 发送Get 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public Task<byte[]> GetToBytes(string url)
        {
            return m_WebManager.GetToBytes(url);
        }

        /// <summary>
        /// 发送Get 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryString">请求参数</param>
        /// <returns></returns>
        public Task<byte[]> GetToBytes(string url, Dictionary<string, string> queryString)
        {
            return m_WebManager.GetToBytes(url, queryString);
        }

        /// <summary>
        /// 发送Get 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="queryString">请求参数</param>
        /// <param name="header">请求头</param>
        /// <returns></returns>
        public Task<byte[]> GetToBytes(string url, Dictionary<string, string> queryString, Dictionary<string, string> header)
        {
            return m_WebManager.GetToBytes(url, queryString, header);
        }


        /// <summary>
        /// 发送Post 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="from">请求参数</param>
        /// <returns></returns>
        public Task<string> PostToString(string url, Dictionary<string, string> from = null)
        {
            return m_WebManager.PostToString(url, from);
        }

        /// <summary>
        /// 发送Post 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="from">表单请求参数</param>
        /// <param name="queryString">URl请求参数</param>
        /// <returns></returns>
        public Task<string> PostToString(string url, Dictionary<string, string> from, Dictionary<string, string> queryString)
        {
            return m_WebManager.PostToString(url, from, queryString);
        }

        /// <summary>
        /// 发送Post 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="from">表单请求参数</param>
        /// <param name="queryString">URl请求参数</param>
        /// <param name="header">请求头</param>
        /// <returns></returns>
        public Task<string> PostToString(string url, Dictionary<string, string> from, Dictionary<string, string> queryString, Dictionary<string, string> header)
        {
            return m_WebManager.PostToString(url, from, queryString, header);
        }


        /// <summary>
        /// 发送Post 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="from">请求参数</param>
        /// <returns></returns>
        public Task<byte[]> PostToBytes(string url, Dictionary<string, string> from)
        {
            return m_WebManager.PostToBytes(url, from);
        }

        /// <summary>
        /// 发送Post 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="from">表单请求参数</param>
        /// <param name="queryString">URl请求参数</param>
        /// <returns></returns>
        public Task<byte[]> PostToBytes(string url, Dictionary<string, string> from, Dictionary<string, string> queryString)
        {
            return m_WebManager.PostToBytes(url, from, queryString);
        }

        /// <summary>
        /// 发送Post 请求
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="from">表单请求参数</param>
        /// <param name="queryString">URl请求参数</param>
        /// <param name="header">请求头</param>
        /// <returns></returns>
        public Task<byte[]> PostToBytes(string url, Dictionary<string, string> from, Dictionary<string, string> queryString, Dictionary<string, string> header)
        {
            return m_WebManager.PostToBytes(url, from, queryString, header);
        }
    }
}