import { InputText } from "./style"

export const Input = ({
    placeholder,
    editable,
    fieldvalue,
    onChangeText,
    keyType,
    maxLength
}) => {
    return (
        <InputText
            placeholder={placeholder}
            editable={editable}
            keyboardType={keyType}
            maxLength={maxLength}
            value={fieldvalue}
            onChangeText={onChangeText}
        />
    )
}