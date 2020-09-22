﻿using CSJ2K.j2k.codestream.reader;

namespace DICOMReporting.Formulas {
	public class EchoManualFormula : IFormula {
		private Constants constants;
		public double GetZScore(double measurement) {
			return (measurement - constants.Average) / constants.SD;
		}
		public bool ZScoreable() => constants.Age >= 3;
		public static EchoManualFormula MVDecelTime(double Age) {
			double[] averages = { 145, 157, 172 };
			double[] sds = { 18, 19, 22 };
			return new EchoManualFormula(new Constants(averages, sds, Age));
		}
		public static EchoManualFormula LVIVRT(double Age) {
			double[] averages = { 62, 67, 74 };
			double[] sds = { 10, 10, 13 };
			return new EchoManualFormula(new Constants(averages, sds, Age));
		}
		private EchoManualFormula(Constants constants) {
			this.constants = constants;
		}
		private struct Constants {
			public double Age {
				get; private set;
			}
			public double Average {
				get; private set;
			}
			public double SD {
				get; private set;
			}
			public Constants(double[] averages, double[] sds, double age) {
				Age = age;
				int bracket;
				if (age <= 8) {
					bracket = 0;
				}
				else if (age <= 12) {
					bracket = 1;
				}
				else {
					bracket = 2;
				}
				Average = averages[bracket];
				SD = sds[bracket];
			}
		}
	}
}
