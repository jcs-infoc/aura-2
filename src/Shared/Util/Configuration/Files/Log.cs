﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

namespace Aura.Shared.Util.Configuration.Files
{
	/// <summary>
	/// Represents log.conf
	/// </summary>
	public class LogConfFile : ConfFile
	{
		public bool Archive { get; protected set; }
		public LogLevel Hide { get; protected set; }

		public void Load()
		{
			this.RequireAndInclude("{0}/conf/log.conf", "system", "user");

			this.Archive = this.GetBool("log.archive", true);
			this.Hide = (LogLevel)this.GetInt("log.cmd_hide", (int)(LogLevel.Debug));

			if (this.Archive)
				Log.Archive = "log/archive/";
			Log.LogFile = string.Format("log/{0}.txt", System.AppDomain.CurrentDomain.FriendlyName.Replace(".exe", "").Replace(".vshost", ""));
			Log.Hide |= this.Hide;
		}
	}
}