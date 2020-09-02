using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.Sheepo.Data;
using LiveSplit.Sheepo.Memory;
using LiveSplit.Sheepo.UI;
using LiveSplit.UI;
using LiveSplit.UI.Components;

namespace LiveSplit.Sheepo
{
    public class SheepoComponent : IComponent
    {
	    private TimerModel timer;
	    private SheepoMemory memory;
	    private SheepoMasterControl masterControl;
	    private SplitCollection splitCollection;

	    public SheepoComponent()
	    {
			memory = new SheepoMemory();
			masterControl = new SheepoMasterControl();
			splitCollection = new SplitCollection();
	    }

	    public string ComponentName => "Sheepo Autosplitter";

	    public float HorizontalWidth => 0;
	    public float MinimumHeight => 0;
	    public float VerticalHeight => 0;
	    public float MinimumWidth => 0;
	    public float PaddingTop => 0;
	    public float PaddingBottom => 0;
	    public float PaddingLeft => 0;
	    public float PaddingRight => 0;

	    public IDictionary<string, Action> ContextMenuControls => null;

	    public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
	    {
	    }

	    public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
	    {
	    }

	    public Control GetSettingsControl(LayoutMode mode)
	    {
		    return masterControl;
	    }

	    public XmlNode GetSettings(XmlDocument document)
	    {
		    var root = document.CreateElement("Settings");
		    var version = document.CreateElement("Version", Utilities.GetVersion());
		    var autostart = document.CreateElement("Autostart", masterControl.ShouldAutostart);
		    var e = document.CreateElement("Splits");

		    var splits = masterControl.SplitsControl.ExtractSplits();
		    splitCollection.Splits = splits;
			
		    // Splits can be null if the user hasn't added any splits through the UI.
		    if (splits == null)
		    {
			    foreach (var s in splits)
			    {
				    var split = document.CreateElement("Split");
				    split.AppendChild(document.CreateElement("Type", s.Type.ToString()));
				    split.AppendChild(document.CreateElement("Data", s.Data));

				    e.AppendChild(split);
			    }
		    }

		    root.AppendChild(version);
		    root.AppendChild(autostart);
		    root.AppendChild(e);

		    return root;
	    }

	    public void SetSettings(XmlNode settings)
	    {
		    masterControl.ShouldAutostart = bool.Parse(settings["Autostart"].InnerText);

		    var nodes = settings["Splits"].GetElementsByTagName("Split");
		    var splits = new Split[nodes.Count];

		    for (int i = 0; i < nodes.Count; i++)
		    {
			    var n = nodes[i];
			    var type = (SplitTypes)Enum.Parse(typeof(SplitTypes), n["Type"].InnerText);
			    var data = int.Parse(n["Data"].InnerText);

				splits[i] = new Split(type, data);
		    }

		    splitCollection.Splits = splits;
			masterControl.SplitsControl.Refresh(splits);
	    }

	    public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
	    {
		    if (timer == null)
		    {
				timer = new TimerModel();
				timer.CurrentState = state;
		    }

			Refresh(state.CurrentPhase);
	    }

	    public void Refresh(TimerPhase? nullablePhase = null)
	    {
		    if (!Hook())
		    {
			    return;
		    }

			// The phase will only be null while testing through the console program.
		    if (!nullablePhase.HasValue)
		    {
			    return;
		    }

		    var phase = nullablePhase.Value;

		    if (phase == TimerPhase.NotRunning)
		    {
		    }
	    }

	    private bool Hook()
	    {
		    var previouslyHooked = memory.IsProcessHooked;

		    // It's possible for the timer to be running before Sheepo is launched. If this happens, all splits are
		    // treated as manual until the process is hooked, at which point the run state is updated appropriately.
		    if (memory.Hook() && !previouslyHooked && timer?.CurrentState.CurrentPhase == TimerPhase.Running)
		    {
		    }

		    return memory.IsProcessHooked;
	    }

	    public void Dispose()
	    {
	    }
    }
}
