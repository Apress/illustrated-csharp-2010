using System;
using System.ComponentModel;                         // Must have this namespace
using System.Threading;                              // Must have this namespace

namespace Examples
{
   class DoBackgroundwork
   {
      BackgroundWorker bgWorker = new BackgroundWorker();

      public long BackgroundTotal   { get; private set; }
      public bool CompletedNormally { get; private set; }

      // Constructor
      public DoBackgroundwork()
      {
         // Set BackgroundWorker properties
         bgWorker.WorkerReportsProgress = true;
         bgWorker.WorkerSupportsCancellation = true;

         // Connect handlers to BackgroundWorker object.
         bgWorker.DoWork += DoWork_Handler;
         bgWorker.ProgressChanged += ProgressChanged_Handler;
         bgWorker.RunWorkerCompleted += RunWorkerCompleted_Handler;
      }

      public void StartWorker()
      {
         if ( !bgWorker.IsBusy )
            bgWorker.RunWorkerAsync();
      }

      // This just calculates the sum of the integers from 0 to the input value.
      public static long CalculateTheSequence( long value )
      {
         long total = 0;
         for ( int i=0; i < value; i++ )
            total += i;
         return total;
      }

      public void DoWork_Handler( object sender, DoWorkEventArgs args )
      {
         BackgroundWorker worker = sender as BackgroundWorker;

         // Do the background calculation
         long total = 0;
         for ( int i = 1; i <= 5; i++ )
         {
            // Each time through the loop, check to see if we've been cancelled
            if ( worker.CancellationPending )
            {
               args.Cancel = true;
               worker.ReportProgress( -1 );
               break;
            }
            else
            {
               // If we haven't been cancelled, then continue the calculation.
               total += CalculateTheSequence( i * 10000000 );
               worker.ReportProgress( i * 20 );

               // Slow the program down to a more comfortable output rate
               // just for this demo.
               Thread.Sleep( 300 );
            }
         }

         args.Result = total;       // Store the result and exit.
      }

      // Handle input from background thread.
      private void ProgressChanged_Handler
                     ( object sender, ProgressChangedEventArgs args )
      {
         string output
                  = args.ProgressPercentage == -1
                     ? "             Cancelled"
                     : string.Format( "             {0}%", args.ProgressPercentage );

         Console.WriteLine( output );
      }

      // On completion of background thread, summarize and store the result.
      private void RunWorkerCompleted_Handler
                     ( object sender, RunWorkerCompletedEventArgs args )
      {
         CompletedNormally = !args.Cancelled;
         BackgroundTotal = args.Cancelled
                                    ? 0
                                    : (long) args.Result;   // Cast from object
      }

      public void Cancel()
      {
         if ( bgWorker.IsBusy )
            bgWorker.CancelAsync();
      }
   }

   class Program
   {
      static void Main()
      {
         GiveInstructionsToTheUser();
         OutputTheSummaryHeaders();

         // Create and Start the background worker
         DoBackgroundwork bgw = new DoBackgroundwork();
         bgw.StartWorker();

         // Start the computation on the main thread.  Each time through the loop, 
         // check to see whether the user has cancelled the background thread.
         // After the calculation, add a short sleep, just to slow the program
         // down enough so the main thread doesn't run faster than the background.
         long mainTotal = 0;
         for ( int i = 0; i < 5; i++ )
         {
            if ( Program.CheckForCancelInput() )
               bgw.Cancel();

            mainTotal += DoBackgroundwork.CalculateTheSequence( 100000000 );
            Thread.Sleep( 200 );
            Console.WriteLine( "    {0}%", ( i + 1 ) * 20 );
         }

         SummarizeResults( bgw, mainTotal );
         Console.ReadLine();
      }

      private static void GiveInstructionsToTheUser()
      {
         Console.WriteLine( "Press <Enter> to start background worker." );
         Console.WriteLine( "Press <Enter> again to cancel background worker." );
         Console.ReadLine();
      }

      private static void OutputTheSummaryHeaders()
      {
         Console.WriteLine( "    Main   Background" );
         Console.WriteLine( "---------------------" );
      }


      private static void SummarizeResults( DoBackgroundwork bgw, long mainTotal )
      {
         if ( bgw.CompletedNormally )
         {
            Console.WriteLine( "\nBackground completed Normally" );
            Console.WriteLine( "Background total = {0}", bgw.BackgroundTotal );
         }
         else
         {
            Console.WriteLine( "\nBackground       Cancelled" );
         }

         Console.WriteLine( "Main total       = {0}", mainTotal );
      }

      private static bool CheckForCancelInput()
      {
         bool doCancel = Console.KeyAvailable;
         if ( doCancel )
            Console.ReadKey();
         return doCancel;
      }
   }
}
