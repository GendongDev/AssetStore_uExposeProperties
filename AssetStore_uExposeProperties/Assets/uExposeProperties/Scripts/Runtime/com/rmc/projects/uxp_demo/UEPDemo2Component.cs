/**
 * Copyright (C) 2005-2014 by Rivello Multimedia Consulting (RMC).                    
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
	public class UEPDemo2Component : MonoBehaviour 
	{
		
		//--------------------------------------
		//  Attributes
		//--------------------------------------

		//--------------------------------------
		//  Properties
		//--------------------------------------
		
		//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		//\ 
		//\ uExposePropertites Examples
		//\ 
		//\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


		/// <summary>
		/// Sample Float
		/// </summary>
		[SerializeField][HideInInspector]
		private float _distanceMaximum_float = 15;
		[ExposeProperty]
		public float distanceMax {
			get{
				return _distanceMaximum_float;
			}
			set{

				_distanceMaximum_float = Mathf.Clamp (value, _distanceMinimum_float, Mathf.Infinity) ;
				
				//
				_doRefreshProperties();

			}
		}

		/// <summary>
		/// Sample Float
		/// </summary>
		[SerializeField][HideInInspector]
		private float _distanceMinimum_float = 15;
		[ExposeProperty]
		public float distanceMinimum {
			get{
				return _distanceMinimum_float;
			}
			set{
				
				_distanceMaximum_float = Mathf.Clamp (value, _distanceMinimum_float, Mathf.Infinity) ;
				
				//
				_doRefreshProperties();
				
			}
		}



		/// <summary>
		/// The _viewport bounds_rect.
		/// </summary>
		[SerializeField][HideInInspector] 
		private Rect _viewportBoundary_rect = new Rect (-30, -35, 60, 70);
		[ExposeProperty]
		public Rect viewportBoundary {
			get{
				return _viewportBoundary_rect;
			}
			set{
				_viewportBoundary_rect = value;
				
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

			Debug.Log ("Rect: " + _viewportBoundary_rect);
			
		}

		//--------------------------------------
		//  Events
		//--------------------------------------
		/// <summary>
		/// Raises the enable event.
		/// </summary>
		public void OnEnable ()
		{

			//REFRESH PRIORITY
			_doRefreshProperties();
		}


	}


}
