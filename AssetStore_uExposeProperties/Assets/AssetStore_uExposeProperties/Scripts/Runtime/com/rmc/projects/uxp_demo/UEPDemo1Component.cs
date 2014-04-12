/**
 * Copyright (C) 2005-2013 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.                                      
 */
// Marks the right margin of code *******************************************************************


//--------------------------------------
//  Imports
//--------------------------------------
using UnityEngine;
using com.unity3d.wiki.expose_properties;

//--------------------------------------
//  Namespace
//--------------------------------------
namespace com.rmc.projects.uxp_demo
{
	
	//--------------------------------------
	//  Namespace Properties
	//--------------------------------------
	
	//--------------------------------------
	//  Class Attributes
	//--------------------------------------
	
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	public class UEPDemo1Component : MonoBehaviour 
	{
		
		//--------------------------------------
		//  Attributes
		//--------------------------------------
		public enum AnyCustomEnum
		{
			SampleValue1,
			SampleValue2

		}

		
		//--------------------------------------
		//  Properties
		//--------------------------------------
		
		//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		//\ 
		//\ REQUIRED VALUES
		//\ 
		//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		/// <summary>
		/// Object's Priority for Camera Tracking
		/// 
		/// NONE: 	Not Tracked
		/// LOW: 	Tracked
		/// HIGH: 	Tracked
		/// 
		/// If the camera cannot track all objects due to limitations, 
		/// it will emphasise tracking for HIGH objects.
		/// 
		/// 
		/// </summary>
		[SerializeField][HideInInspector]
		private AnyCustomEnum _trackingPriority;
		[ExposeProperty]
		public AnyCustomEnum trackingPriority {
			get{
				return _trackingPriority;
			}
			set{
				_trackingPriority = value;

				//
				_doRefreshProperties();

			}
		}
		
		
		//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		//\ 
		//\ BONUS VALUES
		//\ 
		//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

		/// <summary>
		/// Optional border padding (for debug rendering & all detection)
		/// </summary>
		[SerializeField][HideInInspector]
		private float _borderPadding_float = 0.2f;
		[ExposeProperty]
		public float borderPadding {
			get{
				return _borderPadding_float;
			}
			set{
				_borderPadding_float = Mathf.Clamp (value, 0, Mathf.Infinity);
				
				//
				_doRefreshProperties();
			}
		}

		
		

		//--------------------------------------
		//  Methods
		//--------------------------------------	

		//	PUBLIC 

		/// <summary>
		/// Start this instance.
		/// </summary>
		void Start () 
		{

		}
		
		
		///<summary>
		///	Called once per frame
		///</summary>
		void Update () 
		{


		}


		//	PRIVATE 
		/// <summary>
		/// 
		/// Refresh properties.
		/// 
		/// NOTE: This is not a required pattern for UEXP
		/// NOTE: This is recommended when you have many interdependent properties, for cleaner code
		/// 
		/// </summary>
		private void _doRefreshProperties() 
		{
			
			
		}

		//--------------------------------------
		//  Events
		//--------------------------------------
		/// <summary>
		/// Raises the enable event.
		/// </summary>
		void OnEnable ()
		{
			//REFRESH PRIORITY
			_doRefreshProperties();

		}

		
	}
}
