import React from 'react'

export default function Radio({type}) {

    let radioPermanentOrFullTimeValue = "";
    let radioContractOrPartTimeValue = "";

    let radioPermanentOrFullTimeLabel = "";
    let radioContractOrPartTimeLabel = "";

    if (type && type === "contract") {
        radioPermanentOrFullTimeValue = "contractPermanent";
        radioContractOrPartTimeValue = "contractContract";
        radioPermanentOrFullTimeLabel = "Permanent";
        radioContractOrPartTimeLabel = "Contract";
    } else {
        radioPermanentOrFullTimeValue = "fullTime";
        radioContractOrPartTimeValue = "partTime";
        radioPermanentOrFullTimeLabel = "Full-time";
        radioContractOrPartTimeLabel = "Part-time";
    }
    
    return (
        <div className="col-12">
            <div className="form-check">
                <input className="form-check-input" type="radio" name="typeRadios" id={radioPermanentOrFullTimeValue} value={radioPermanentOrFullTimeValue} checked />
                <label className="form-check-label" for={radioPermanentOrFullTimeValue}>
                    {radioPermanentOrFullTimeLabel}
                </label>
            </div>
            <div className="form-check">
                <input className="form-check-input" type="radio" name="typeRadios" id={radioContractOrPartTimeValue} value={radioContractOrPartTimeValue} />
                <label className="form-check-label" for="contract">
                    {radioContractOrPartTimeLabel}
                </label>
            </div>
        </div>
    )
}
