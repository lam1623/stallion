using System;
using System.Text;
using System.Threading;
using System.Diagnostics;
using Mono.Unix;

namespace stallion
{
    public class Process : System.Diagnostics.Process
    {
	    private Thread t;
		private stallion.Video node = null;

		public stallion.Video Node {
			get {
				return this.node;
			}
			set {
				node = value;
			}
		}	

		public System.Threading.Thread T {
			get {
				return this.t;
			}
			set {
				t = value;
			}
		}        
		
        public Process (){
			
			StartInfo.UseShellExecute = false;
			StartInfo.RedirectStandardOutput = true; 
			StartInfo.RedirectStandardError = true;
			StartInfo.StandardOutputEncoding = Encoding.ASCII;
            StartInfo.StandardErrorEncoding = Encoding.ASCII;
        }
        
		public Void CreateProcessVideo(stallion.Video node,string Argumento,string DirectorioTrabajo)
        {  			
			this.node = node;
            StartInfo.FileName = "/usr/bin/mencoder" ;
            StartInfo.Arguments = Argumento; 
            StartInfo.WorkingDirectory = DirectorioTrabajo;
        }
		
        public Void CreateProcess(string programa,string Argumento,string DirectorioTrabajo)
        {                       
            StartInfo.FileName = programa;
            StartInfo.Arguments = Argumento; 
            StartInfo.WorkingDirectory = DirectorioTrabajo;
        }
		
		public void StartProcess(){
			t.Start();			
        }
		
        public void StopProcess() {
			t.Abort();			
        }
		
		public void PauseProcess() {
			t.Suspend();   
			
        }
		
		public void ResumeProcess() {
			t.Resume();			         
        }
    }
}