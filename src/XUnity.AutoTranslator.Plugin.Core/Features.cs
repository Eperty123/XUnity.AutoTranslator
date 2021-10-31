﻿using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using UnityEngine;
using XUnity.Common.Constants;

namespace XUnity.AutoTranslator.Plugin.Core
{
   /// <summary>
   /// Class that allows you to check which features are availble of the Unity version that is used.
   /// </summary>
   public static class Features
   {
      internal static bool SupportsMouseScrollDelta { get; } = false;

      internal static bool SupportsClipboard { get; } = false;

      internal static bool SupportsReflectionEmit { get; } = false;

      /// <summary>
      /// Gets a bool indicating if the class CustomYieldInstruction is available.
      /// </summary>
      public static bool SupportsCustomYieldInstruction { get; } = false;

      /// <summary>
      /// Gets a bool indicating if the SceneManager class is available.
      /// </summary>
      public static bool SupportsSceneManager { get; } = false;

      /// <summary>
      /// Gets a bool indicating if this game is running in a .NET 4.x runtime.
      /// </summary>
      public static bool SupportsNet4x { get; } = false;

      /// <summary>
      /// Gets a bool indicating if the WaitForSecondsRealtime class is supported.
      /// </summary>
      public static bool SupportsWaitForSecondsRealtime { get; internal set; } = false;
       
      static Features()
      {
         try
         {
            SupportsClipboard = ClrTypes.TextEditor?.GetProperty( "text" )?.GetSetMethod() != null;
         }
         catch( Exception )
         {
            
         }

         try
         {
            SupportsCustomYieldInstruction = ClrTypes.CustomYieldInstruction != null;
         }
         catch( Exception )
         {
            
         }

         try
         {
            SupportsSceneManager = ClrTypes.Scene != null
               && ClrTypes.SceneManager != null
               && ClrTypes.SceneManager.GetMethod( "add_sceneLoaded", BindingFlags.Static | BindingFlags.Public ) != null;
         }
         catch( Exception )
         {

         }

         try
         {
            SupportsNet4x = ClrTypes.Task != null;
         }
         catch( Exception )
         {

         }

         try
         {
            SupportsMouseScrollDelta = typeof( Input ).GetProperty( "mouseScrollDelta" ) != null;
         }
         catch( Exception )
         {

         }

         try
         {
            SupportsWaitForSecondsRealtime = ClrTypes.WaitForSecondsRealtime != null;
         }
         catch( Exception )
         {

         }

         try
         {
            TestReflectionEmit();

            SupportsReflectionEmit = true;
         }
         catch( Exception )
         {
            SupportsReflectionEmit = false;
         }
      }

      private static void TestReflectionEmit()
      {
         MethodToken t1 = default( MethodToken );
         MethodToken t2 = default( MethodToken );
         var ok = t1 == t2;
      }

      /// <summary>
      /// Gets the WaitForSecondsRealtime CustomYieldInstruction if supported.
      /// </summary>
      /// <param name="delay"></param>
      /// <returns></returns>
      public static IEnumerator GetWaitForSecondsRealtime( float delay )
      {
         if( SupportsWaitForSecondsRealtime )
         {
            return GetWaitForSecondsRealtimeInternal( delay );
         }
         return null;
      }

      private static IEnumerator GetWaitForSecondsRealtimeInternal( float delay )
      {
         return new WaitForSecondsRealtime( delay );
      }
   }
}
