using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BratnetProvider
{
    public enum DocumentDeviationType
    {
        /// <summary>
        /// This value is used for Data Transmission by the Recipient due Failure to Transmit it Publisher.
        /// Allowed types documents: 1.1, 1.6, 2.1, 2.4, 5.2, 8.1 and 8.2
        /// </summary>
        RecipientOmissiontransmission,

        /// <summary>
        /// This value is used for Data Transmission from the Publisher, at case it agrees with the 
        /// Recipient's label on failure to transmit by (publisher) Allowed types documents: 11.3, 11.4, 13.1, and 13.31
        /// </summary>
        IssuerOmissionTransmission,

        /// <summary>
        /// This value is used for Data Transmission (non counter documents) by the Recipient due Transmission Deviation
        /// Given by the Publisher Allowed types documents: 11.3, 11.4, 13.1, and 13.31 
        /// (Especially and exclusively for documents issued within 2021 are allowed in addition and types 1.1 and 5.2)
        /// </summary>
        TransmissionOfDeviationFromReceiver,

        /// <summary>
        /// This value is used for Data Transmission myDATA REST API 65 from the Publisher, at case it agrees with the 
        /// Recipient's label "Transmission Deviation" in facing press Document A1 that he had forward to the Receiver 
        /// Allowed types documents: 11.3, 11.4, 13.1, and 13.31
        /// </summary>
        TransmissionOfDeviationFromPublisher,
    }
}
