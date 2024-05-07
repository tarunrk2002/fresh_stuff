//using System.Reflection.Metadata;

//private void addToolStripMenuItem_Click(object sender, EventArgs e)
//{
//    LogWriter.LogWrite("ATCCControlCenter_toolStripAdd_Click() BEGIN");

//    if (treeView1.SelectedNode.Tag != null)
//        return;

//    // Add single Device at a time

//    AddDetector addDetector = new AddDetector();

//    addDetector.Owner = this;

//    if (addDetector.ShowDialog() == DialogResult.OK)
//    {
//        //UpdateDetectors();

//        try
//        {
//            ICDeviceDetails lane = CDatabaseManager.GetInstance().GetICRecord(addDetector.MACid);
//            TreeNode laneNode = new TreeNode(lane.ToString());
//            laneNode.ContextMenuStrip = contextMenuTreeView;
//            laneNode.Tag = lane;
//            laneNode.Nodes.Add("Detectors");
//            List<ControllerInformation> detectors = CDatabaseManager.GetInstance().GetChannelInfo(addDetector.MACid);
//            foreach (var channel in detectors)
//            {
//                TreeNode detectorChildNode = new TreeNode(channel.GetChannelName());
//                detectorChildNode.ContextMenuStrip = GetContextMenuStripDetector(lane.LPUs[channel.ChannelID - 1].IsEnabled);
//                detectorChildNode.Tag = channel;
//                laneNode.Nodes[0].Nodes.Add(detectorChildNode);
//            }

//            laneNode.Nodes.Add("Reports");
//            treeView1.Nodes[0].Nodes.Add(laneNode);
//            ICManager.GetInstance().Add(lane, detectors);
//            deviceStatistics.UpdateDetails();
//            ICManager.GetInstance().Start();
//            treeView1.Refresh();

//        }
//        catch (Exception ex)
//        {
//            LogWriter.LogWrite(String.Format("ATCCControlCenter_addToolStripMenuItem_Clickl():{0}", ex.ToString()));
//        }
//    }
//    LogWriter.LogWrite("ATCCControlCenter_toolStripAdd_Click() END");
//}