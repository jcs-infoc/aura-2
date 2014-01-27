using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Aura.Channel.Network.Sending;
using Aura.Channel.Scripting.Scripts;
using Aura.Channel.World;
using Aura.Channel.World.Entities;
using Aura.Shared.Mabi;
using Aura.Shared.Util;

public class NormalNpcAi : AiScript
{
	public NormalNpcAi()
	{
		SetHeartbeat(5000);
	}

	protected override void Idle()
	{
		SayRandomPhrase();
		Wait(20000, 50000);
	}
}