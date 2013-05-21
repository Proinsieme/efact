using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls.Calendar;
using eFact.BLL;
using eFact;
using System.Configuration;

namespace CalendarDayButtonStyle
{
    public class DayButtonStyleSelector : System.Windows.Controls.StyleSelector 
    {
        public Style SpecialStyleWeekDays { get; set; }
        public Style SpecialStyleWeekEnds { get; set; }

        string EmployeeId = ConfigurationManager.AppSettings["EmployeeId"].ToString();

        class LeaveDetails
        {
            public string LeaveReason { get; set; }
            public DateTime LeaveDate { get; set; }
            public string LeaveType { get; set; }
        }

        public override Style SelectStyle(object item, DependencyObject container) 
        {
			// Add custom Tooltip for each calendar button
			Control control = container as Control;
            Leave objLeave = new Leave();
            List<Leave> leaveList = new List<Leave>();
            //FrmHumanResource objFrmHumanResource = null;
            //int EmployeeId = objFrmHumanResource.GetEmployeeId();
            if (EmployeeId == "")
            {
                EmployeeId = "34,1034,1035,1036,1037,1038,1039,1040,1041,1042,1043,1044,1045";
            }
            //int EmployeeId = 28;
            if (EmployeeId != "")
            {
                leaveList = objLeave.GetLeaveDetailsCalendarByEmployeeId(EmployeeId);
                if (control != null)
                {
                    CalendarButtonContent buttonContent = (item as CalendarButtonContent);
                    foreach (Leave selectedLeave in leaveList)
                    {
                        if (buttonContent.Date == Convert.ToDateTime(selectedLeave.LeaveStartDate))
                        {
                            if ((buttonContent.Date.DayOfWeek != DayOfWeek.Sunday || buttonContent.Date.DayOfWeek != DayOfWeek.Saturday)) // && buttonContent.ButtonType != CalendarButtonType.Date)
                            {
                                control.ToolTip = new ToolTip() { Content = selectedLeave.LeaveStartDate +"\n" + selectedLeave.LeaveType + "\n" + selectedLeave.LeaveReason };
                                control.FontWeight = FontWeights.Bold;

                                if (selectedLeave.LeaveType.Trim() == "Cassual Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.Red;
                                }
                                else if (selectedLeave.LeaveType.Trim() == "Marriage Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.Purple;
                                }
                                else if (selectedLeave.LeaveType.Trim() == "House Move Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.Yellow;
                                }
                                else if (selectedLeave.LeaveType.Trim() == "Maternity Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.Green;
                                }
                                else if (selectedLeave.LeaveType.Trim() == "Mortality Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.Cyan;
                                }
                                else if (selectedLeave.LeaveType.Trim() == "Sick Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.Orange;
                                }
                                else if (selectedLeave.LeaveType.Trim() == "Paternity Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.BurlyWood;
                                }
                                else if (selectedLeave.LeaveType.Trim() == "Special Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.LightGreen;
                                }
                                else if (selectedLeave.LeaveType.Trim() == "Study Leave")
                                {
                                    control.Background = System.Windows.Media.Brushes.Blue;
                                }
                            }
                        }
                    }
                }
            }
            return base.SelectStyle(item, container);
        }
    }
}
