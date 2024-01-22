type StatusProps = {
    status: 'Loading' | 'success'| 'error'
}


export default function Status(props: StatusProps) {
    let message
    if (props.status === 'Loading') {
        message = 'Loading...'
    } else if (props.status === 'success'){
        message = 'Data fetched succesfully!'
    }else if (props.status === 'error'){
        message = 'Error fetching Data'
    }
  return (
    <div>
        <h2>status - {message} </h2>
        
    </div>
  )
}
