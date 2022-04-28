using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PassengerTrainFinalProject
{
    public partial class PassengerTrainBoarding : Form
    {
        private const string FirstClassGroup = "First Class Group:";
        private const string GroupDivider = "==================";
        private const string PriorityGroup = "Priority Group:";
        private const string PriorityGroupDivider = "===============";
        private const string StandardGroup = "Standard Group:";
        private const string StandardGroupDivider = "===============";
        private const string BoardingGroupOne = "Boarding Group 1:";
        private const string BoardingGroupTwo = "Boarding Group 2:";
        private const string BoardingGroupThree = "Boarding Group 3:";
        private const string BoardingGroupDivider = "=================";
        private const string PassengersGroup = "Passengers:";
        private const string PassengersGroupDivider = "===========";

        private const int FirstClassSize = 41;
        private const int StandardSize = 56;


        private readonly string[] _firstClassSeats = new[] {"F03", "F04", "F07", "F08", "F09", "F10", "F11", "F12", "F13", "F14", "F15", "P05", "P06", "P19", "F18", "F20", "F21", "S22", "S23", "S24", "S25", "S26", "S27", "S28", "S29", "S30", "S31", "S32", "S33", "S34", "S35", "S36", "S37", "S38", "S39", "S40", "S41", "S42", "S43", "S44", "S45" };
        private readonly string[] _firstClassSeatGroup1 = new [] {"F03", "F04", "F07", "F08", "F09", "F10", "F11", "F12", "F13", "F14", "F15", "F16", "F17", "F18", "F20", "F21"};
        private readonly string[] _firstClassSeatGroup2 = new [] {"P05", "P06", "P19"};
        private readonly string[] _firstClassSeatGroup3 = new [] {"S22", "S23", "S24", "S25", "S26", "S27", "S28", "S29", "S30", "S31", "S32", "S33", "S34", "S35", "S36", "S37", "S38", "S39", "S40", "S41", "S42", "S43", "S44", "S45"};

        private readonly string[] _standardSeats = new [] {"S01", "S02", "S03", "S04", "S05", "S06", "S07", "S08", "S09", "S10", "S11", "S12", "S13", "S14", "S15", "S16", "S17", "S18", "S19", "S20", "S21", "S22", "S23", "S24", "S25", "S26", "S27",
                                                           "S28", "S29", "S30", "S31", "S32", "S33", "S34", "S35", "S36", "S37", "S38", "S39", "S40", "S41", "S42", "S43", "S44", "S45", "S46", "S47", "S48", "S49", "S50", "S51",
                                                           "S52", "S53", "S54", "S55", "S56"};
        private readonly string[] _standardSeatGroup1 = new [] {"S01", "S02", "S03", "S04", "S05", "S06", "S07", "S08", "S09", "S10", "S11", "S12", "S13", "S14", "S15", "S16", "S17", "S18"};
        private readonly string[] _standardSeatGroup2 = new [] {"S19", "S20", "S21", "S22", "S23", "S24", "S25", "S26", "S27", "S28", "S29", "S30", "S31", "S32", "S33", "S34", "S35", "S36"};
        private readonly string[] _standardSeatGroup3 = new [] { "S37", "S38", "S39", "S40", "S41", "S42", "S43", "S44", "S45", "S46", "S47", "S48", "S49", "S50", "S51", "S52", "S53", "S54", "S55", "S56"};

        private List<Passenger> _passengerList = new List<Passenger>();
        private readonly Queue _lineOneQueue = new Queue();

        public PassengerTrainBoarding()
        {
            InitializeComponent();
        }

        /**************************************************************
        * Name: generatePassengersButton_Click
        * Description: Generates a set number of passengers with random first and last names.
        * Input:
        * Output:
        ***************************************************************/
        private void generatePassengersButton_Click(object sender, EventArgs e)
        {
            string[] allFirstNames = File.ReadAllLines("RandomFirstNames.txt.");
            string[] allLastNames = File.ReadAllLines("RandomLastNames.txt.");
            Random rng = new Random();
            _passengerList.Clear();
            ClearPassengerListBox();
            ClearQueueListBox();
            if (firstClassRadio.Checked)
            {
                for (int i = 0; i < _firstClassSeats.Length; i++)
                {
                    _passengerList.Add(new Passenger(allFirstNames[rng.Next(allFirstNames.Length)], allLastNames[rng.Next(allLastNames.Length)], _firstClassSeats[i]));
                }
            }
            else if (standardClassRadio.Checked)
            {
                for (int i = 0; i < _standardSeats.Length; i++)
                {
                    _passengerList.Add(new Passenger(allFirstNames[rng.Next(allFirstNames.Length)], allLastNames[rng.Next(allLastNames.Length)], _standardSeats[i]));
                }
            }
            Shuffle(_passengerList); //Shuffle list to simulate random nature of passengers purchasing seating.
            UpdatePassengersListBox(_passengerList);
        }

        /**************************************************************
        * Name: sortFirstNameButton_Click
        * Description: Sorts list of passengers by first name.
        ***************************************************************/
        private void sortFirstNameButton_Click(object sender, EventArgs e)
        {
            _passengerList.Sort((x, y) => x.FirstName.CompareTo(y.FirstName));
            ClearPassengerListBox();
            UpdatePassengersListBox(_passengerList);
        }

        /**************************************************************
        * Name: sortLastNameButton_Click
        * Description: Sorts list of passengers by last name.
        ***************************************************************/
        private void sortLastNameButton_Click(object sender, EventArgs e)
        {
            _passengerList.Sort((x, y) => x.LastName.CompareTo(y.LastName));
            ClearPassengerListBox();
            UpdatePassengersListBox(_passengerList);
        }

        /**************************************************************
        * Name: sortSeatButton_Click
        * Description: Sorts list of passengers by seat.
        ***************************************************************/
        private void sortSeatButton_Click(object sender, EventArgs e)
        {
            ClearPassengerListBox();
            List<Passenger> tempPassengerList = new List<Passenger>();
            switch (_passengerList.Count)
            {
                case FirstClassSize:
                {
                    for (int i = 0; i < FirstClassSize; i++)
                    {
                        foreach (var passenger in _passengerList)
                        {
                            if (_firstClassSeats[i] == passenger.Seat)
                            {
                                tempPassengerList.Add(passenger);
                                break;
                            }
                        }
                    }

                    break;
                }
                case StandardSize:
                {
                    for (int i = 0; i < StandardSize; i++)
                    {
                        foreach (var passenger in _passengerList)
                        {
                            if (_standardSeats[i] == passenger.Seat)
                            {
                                tempPassengerList.Add(passenger);
                                break;
                            }
                        }
                    }

                    break;
                }
            }

            _passengerList = tempPassengerList;
            UpdatePassengersListBox(_passengerList);
        }

        /**************************************************************
        * Name: queueButton_Click
        * Description: Creates a queue to board the passenger train based on selected method.
        ***************************************************************/
        private void queueButton_Click(object sender, EventArgs e)
        {
            ClearQueueListBox();
            if (_passengerList.Count == 0)
            {
                MessageBox.Show(@"Please generate customers before attempting to group.");
                return;
            }
            else if (firstClassRadio.Checked && _passengerList.Count == FirstClassSize)
            {
                queue1ListBox.Items.Add(FirstClassGroup);
                queue1ListBox.Items.Add(GroupDivider);
                PrintPassengerGroup(_passengerList, _firstClassSeatGroup1, queue1ListBox);
                queue2ListBox.Items.Add(PriorityGroup);
                queue2ListBox.Items.Add(PriorityGroupDivider);
                PrintPassengerGroup(_passengerList, _firstClassSeatGroup2, queue2ListBox);
                queue3ListBox.Items.Add(StandardGroup);
                queue3ListBox.Items.Add(StandardGroupDivider);
                PrintPassengerGroup(_passengerList, _firstClassSeatGroup3, queue3ListBox);
            }
            else if (standardClassRadio.Checked && _passengerList.Count == StandardSize)
            {
                queue1ListBox.Items.Add(BoardingGroupOne);
                queue1ListBox.Items.Add(BoardingGroupDivider);
                PrintPassengerGroup(_passengerList, _standardSeatGroup1, queue1ListBox);
                queue2ListBox.Items.Add(BoardingGroupTwo);
                queue2ListBox.Items.Add(BoardingGroupDivider);
                PrintPassengerGroup(_passengerList, _standardSeatGroup2, queue2ListBox);
                queue3ListBox.Items.Add(BoardingGroupThree);
                queue3ListBox.Items.Add(BoardingGroupDivider);
                PrintPassengerGroup(_passengerList, _standardSeatGroup3, queue3ListBox);
            }
        }

        /**************************************************************
        * Name: shuffle
        * Description: Shuffles list
        * Input: List<T> inList
        ***************************************************************/
        private void Shuffle<T>(List<T> inList)
        {
            Random rng = new Random();
            int n = inList.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = inList[k];
                inList[k] = inList[n];
                inList[n] = value;
            }
        }

        /**************************************************************
        * Name: updatePassengersListBox
        * Description: Updates list box to reflex list of passengers.
        * Input: List<Passenger> inList
        ***************************************************************/
        private void UpdatePassengersListBox(List<Passenger> inList)
        {
            passengerListBox.Items.Add(PassengersGroup);
            passengerListBox.Items.Add(PassengersGroupDivider);

            foreach (Passenger p in inList)
            {
                passengerListBox.Items.Add(p.FirstName + " " + p.LastName + " " + p.Seat);
            }
        }

        /**************************************************************
        * Name: clearPassengersListBox
        * Description: Removes all items from passengerListBox
        ***************************************************************/
        private void ClearPassengerListBox()
        {
            passengerListBox.Items.Clear();
        }

        /**************************************************************
        * Name: clearQueueListBox
        * Description: Removes all items from queueListBox
        ***************************************************************/
        private void ClearQueueListBox()
        {
            queue1ListBox.Items.Clear();
            queue2ListBox.Items.Clear();
            queue3ListBox.Items.Clear();
        }

        /**************************************************************
        * Name: printPassengerGroup
        * Description: Queues passengers according to selected order and updates list box.
        * Input: List<Passenger> inList, string[] inArray, ListBox inListBox
        ***************************************************************/
        private void PrintPassengerGroup(List<Passenger> inList, string[] inArray, ListBox inListBox)
        {
            for (int i = 0; i < inArray.Length; i++)
            {
                for (int i2 = 0; i2 < inList.Count; i2++)
                {
                    if (inArray[i] == inList[i2].Seat)
                    {
                        _lineOneQueue.Enqueue(_passengerList[i2]);
                        inListBox.Items.Add(_passengerList[i2].FirstName + " " + _passengerList[i2].LastName + " " + _passengerList[i2].Seat);
                        break;
                    }
                }
            }
        }

        /**************************************************************
        * Name: trainFirstRadio_CheckedChanged
        * Description: Changes image of passenger train
        ***************************************************************/
        private void trainFirstRadio_CheckedChanged(object sender, EventArgs e)
        {
            firstClassPictureBox.Visible = true;
            standardClassPictureBox.Visible = false;
            ClearPassengerListBox();
            ClearQueueListBox();
        }

        /**************************************************************
        * Name: trainStandardRadio_CheckedChanged
        * Description: Changes image of passenger train
        ***************************************************************/
        private void trainStandardRadio_CheckedChanged(object sender, EventArgs e)
        {
            standardClassPictureBox.Visible = true;
            firstClassPictureBox.Visible = false;
            ClearPassengerListBox();
            ClearQueueListBox();
        }

        /**************************************************************
        * Name: exitButton_Click
        * Description: Closes the program.
        ***************************************************************/
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
