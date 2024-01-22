type InputProps = {
    value: string 
    handleChange: (e: React.ChangeEvent<HTMLInputElement>)=> void
}
export const Inpuut = (props: InputProps) => {
    const handleInputChange = (e: React.ChangeEvent<HTMLInputElement>) =>{
        console.log(e)

    }
    // return <input type="text" value={props.value} onChange={(e)=>props.handleChange(e)} />
    return <input type="text" value={props.value} onChange={handleInputChange} />
}
