<strong>using System;
using System.Web;
using System.Collections;

public class CookiesHelper
    {
    /**//// <summary>
    /// ��ȡ���ݻ���
    /// </summary>
    /// <param name="CacheKey">��</param>
    public static object GetCache(string CacheKey)
    {
        System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        return objCache[CacheKey];
    }

    /**//// <summary>
    /// �������ݻ���
    /// </summary>
    public static void SetCache(string CacheKey, object objObject)
    {
        System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        objCache.Insert(CacheKey, objObject);
    }

    /**//// <summary>
    /// �������ݻ���
    /// </summary>
    public static void SetCache(string CacheKey, object objObject, TimeSpan Timeout)
    {
        System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        objCache.Insert(CacheKey, objObject, null, DateTime.MaxValue, Timeout, System.Web.Caching.CacheItemPriority.NotRemovable, null);
    }

    /**//// <summary>
    /// �������ݻ���
    /// </summary>
    public static void SetCache(string CacheKey, object objObject, DateTime absoluteExpiration, TimeSpan slidingExpiration)
    {
        System.Web.Caching.Cache objCache = HttpRuntime.Cache;
        objCache.Insert(CacheKey, objObject, null, absoluteExpiration, slidingExpiration);
    }

    /**//// <summary>
    /// �Ƴ�ָ�����ݻ���
    /// </summary>
    public static void RemoveAllCache(string CacheKey)
    {
        System.Web.Caching.Cache _cache = HttpRuntime.Cache;
        _cache.Remove(CacheKey);
    }

    /**//// <summary>
    /// �Ƴ�ȫ������
    /// </summary>
    public static void RemoveAllCache()
    {
        System.Web.Caching.Cache _cache = HttpRuntime.Cache;
        IDictionaryEnumerator CacheEnum = _cache.GetEnumerator();
        while (CacheEnum.MoveNext())
        ...{
            _cache.Remove(CacheEnum.Key.ToString());
        }
    }
}
</strong>