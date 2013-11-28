using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartIIProject
{
    class Contract
    {
        int contractStartDateIndex; //day number
        int contractEndDateIndex; //day number
        int ExerciseFrequency; // days
        int DecisionFrequency; // days
        int numberOfComponents; // for the PCA multi-factor model
        int maxInjectionRate; //barrels
        int maxWithdrawalRate; //barrels
        int injectionCost; // $/barrel
        int withdrawalCost; // $/barrel
        int volumeUnit; //"we descretize the volume units"
    }
}
